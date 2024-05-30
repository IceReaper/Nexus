using LibNexus.Core.Extensions;
using System.Collections.ObjectModel;

namespace LibNexus.Files.TextureFiles;

public class Texture
{
	private const string Magic = "\0GFX";
	private const uint Version = 3;

	private readonly Stream _stream;

	public Collection<Image> Images { get; } = [];

	public Texture(Stream stream)
	{
		_stream = stream;

		var magic = _stream.ReadWord();
		var version = _stream.ReadUInt32();

		if (magic != Magic)
			throw new Exception("Texture: Invalid magic");

		if (version != Version)
			throw new Exception("Texture: Invalid version");

		var header = new TextureHeader(_stream);
		var jpgHeader = header.IsJpg ? header.Format == 0 ? new JpgHeader(_stream) : throw new Exception("Texture: Invalid format") : null;
		var padding = _stream.ReadBytes((ulong)(header.IsJpg ? 4 : 76));

		if (padding.Any(static e => e != 0))
			throw new Exception("Texture: Invalid padding");

		for (var mipMap = header.MipMaps == 0 ? 0 : 1; mipMap <= header.MipMaps; mipMap++)
		{
			var factor = 1 << (int)(header.MipMaps - mipMap);
			var mipWidth = (uint)Math.Max(header.Width / factor + (header.Width % factor == 0 ? 0 : 1), 1);
			var mipHeight = (uint)Math.Max(header.Height / factor + (header.Height % factor == 0 ? 0 : 1), 1);
			var pixels = new byte[mipWidth * mipHeight * 4];

			switch (header.Format)
			{
				case 0 when jpgHeader is { Format: 0 }:
					// TODO Chroma subsampling &amp; typical jpg color space transformation with one additional color channel
					break;

				case 0 when jpgHeader is { Format: 1 }:
					// TODO Four color channels and no color space transformation
					break;

				case 0 when jpgHeader is { Format: 2 }:
					// TODO typical jpg color space transformation with one additional color channel
					break;

				case 0:
					ReadBgra32(stream, pixels, mipWidth, mipHeight);

					break;

				case 1:
					ReadBgra32(stream, pixels, mipWidth, mipHeight);

					break;

				case 5:
					ReadBgra16(stream, pixels, mipWidth, mipHeight);

					break;

				case 6:
					ReadGrayscale(stream, pixels, mipWidth, mipHeight);

					break;

				case 13:
					ReadDxt1(pixels, mipWidth, mipHeight);

					break;

				case 15:
					ReadDxt5(pixels, mipWidth, mipHeight);

					break;

				case 18:
					break;

				default:
					throw new NotSupportedException("Texture: Unsupported format");
			}

			Images.Add(new Image(mipWidth, mipHeight, pixels));
		}
	}

	private static void ReadBgra32(Stream stream, byte[] pixels, uint width, uint height)
	{
		for (var i = 0; i < width * height; i++)
		{
			var b = stream.ReadUInt8();
			var g = stream.ReadUInt8();
			var r = stream.ReadUInt8();
			var a = stream.ReadUInt8();

			pixels[i * 4 + 0] = r;
			pixels[i * 4 + 1] = g;
			pixels[i * 4 + 2] = b;
			pixels[i * 4 + 3] = a;
		}
	}

	private static void ReadBgra16(Stream stream, byte[] pixels, uint width, uint height)
	{
		for (var i = 0; i < width * height; i++)
		{
			var bg = stream.ReadUInt8();
			var ra = stream.ReadUInt8();

			pixels[i * 4 + 0] = (byte)(((ra & 0xF0) << 0) | ((ra & 0xF0) << 4));
			pixels[i * 4 + 1] = (byte)(((bg & 0x0F) << 0) | ((bg & 0x0F) << 4));
			pixels[i * 4 + 2] = (byte)(((bg & 0xF0) << 0) | ((bg & 0xF0) << 4));
			pixels[i * 4 + 3] = (byte)(((ra & 0x0F) << 0) | ((ra & 0x0F) << 4));
		}
	}

	private static void ReadGrayscale(Stream stream, byte[] pixels, uint width, uint height)
	{
		var rowPadding = (4 - width % 4) % 4;

		for (var i = 0; i < width * height; i++)
		{
			var gray = stream.ReadUInt8();

			pixels[i * 4 + 0] = gray;
			pixels[i * 4 + 1] = gray;
			pixels[i * 4 + 2] = gray;
			pixels[i * 4 + 3] = byte.MaxValue;

			if ((i + 1) % width == 0)
				stream.ReadBytes(rowPadding);
		}
	}

	// TODO refactor
	private void ReadDxt1(byte[] pixels, uint width, uint height)
	{
		var bcw = (width + 3) / 4;
		var bch = (height + 3) / 4;
		var clenLast = (width + 3) % 4 + 1;
		var buffer = new uint[16];
		var colors = new uint[4];

		for (var t = 0; t < bch; t++)
		{
			for (var s = 0; s < bcw; s++)
			{
				var q0 = _stream.ReadUInt16();
				var q1 = _stream.ReadUInt16();

				Rgb565To888(q0, out var r0, out var g0, out var b0);
				Rgb565To888(q1, out var r1, out var g1, out var b1);

				colors[0] = Color(r0, g0, b0, 255);
				colors[1] = Color(r1, g1, b1, 255);

				if (q0 > q1)
				{
					colors[2] = Color((byte)((r0 * 2 + r1) / 3), (byte)((g0 * 2 + g1) / 3), (byte)((b0 * 2 + b1) / 3), 255);
					colors[3] = Color((byte)((r0 + r1 * 2) / 3), (byte)((g0 + g1 * 2) / 3), (byte)((b0 + b1 * 2) / 3), 255);
				}
				else
					colors[2] = Color((byte)((r0 + r1) / 2), (byte)((g0 + g1) / 2), (byte)((b0 + b1) / 2), 255);

				var d = _stream.ReadUInt32();

				for (var i = 0; i < 16; i++, d >>= 2)
					buffer[i] = colors[d & 3];

				var clen = (s < bcw - 1 ? 4 : clenLast) * 4;

				for (int i = 0, y = t * 4; i < 4 && y < height; i++, y++)
					Buffer.BlockCopy(buffer, i * 4 * 4, pixels, (int)((y * width + s * 4) * 4), (int)clen);
			}
		}
	}

	// TODO refactor
	private void ReadDxt5(byte[] pixels, uint width, uint height)
	{
		var bcw = (width + 3) / 4;
		var bch = (height + 3) / 4;
		var clenLast = (width + 3) % 4 + 1;
		var buffer = new uint[16];
		var colors = new uint[4];
		var alphas = new uint[8];

		for (var t = 0; t < bch; t++)
		{
			for (var s = 0; s < bcw; s++)
			{
				var tmp = _stream.ReadUInt64();

				alphas[0] = (uint)(tmp & 0xff);
				alphas[1] = (uint)((tmp >> 8) & 0xff);

				if (alphas[0] > alphas[1])
				{
					alphas[2] = (alphas[0] * 6 + alphas[1]) / 7;
					alphas[3] = (alphas[0] * 5 + alphas[1] * 2) / 7;
					alphas[4] = (alphas[0] * 4 + alphas[1] * 3) / 7;
					alphas[5] = (alphas[0] * 3 + alphas[1] * 4) / 7;
					alphas[6] = (alphas[0] * 2 + alphas[1] * 5) / 7;
					alphas[7] = (alphas[0] + alphas[1] * 6) / 7;
				}
				else
				{
					alphas[2] = (alphas[0] * 4 + alphas[1]) / 5;
					alphas[3] = (alphas[0] * 3 + alphas[1] * 2) / 5;
					alphas[4] = (alphas[0] * 2 + alphas[1] * 3) / 5;
					alphas[5] = (alphas[0] + alphas[1] * 4) / 5;
					alphas[7] = 255;
				}

				for (var i = 0; i < 8; i++)
					alphas[i] <<= 24;

				var q0 = _stream.ReadUInt16();
				var q1 = _stream.ReadUInt16();

				Rgb565To888(q0, out var r0, out var g0, out var b0);
				Rgb565To888(q1, out var r1, out var g1, out var b1);

				colors[0] = Color(r0, g0, b0, 0);
				colors[1] = Color(r1, g1, b1, 0);

				if (q0 > q1)
				{
					colors[2] = Color((byte)((r0 * 2 + r1) / 3), (byte)((g0 * 2 + g1) / 3), (byte)((b0 * 2 + b1) / 3), 0);
					colors[3] = Color((byte)((r0 + r1 * 2) / 3), (byte)((g0 + g1 * 2) / 3), (byte)((b0 + b1 * 2) / 3), 0);
				}
				else
					colors[2] = Color((byte)((r0 + r1) / 2), (byte)((g0 + g1) / 2), (byte)((b0 + b1) / 2), 0);

				var da = tmp >> 16;
				var dc = _stream.ReadUInt32();

				for (var i = 0; i < 16; i++, da >>= 3, dc >>= 2)
					buffer[i] = alphas[da & 7] | colors[dc & 3];

				var clen = (s < bcw - 1 ? 4 : clenLast) * 4;

				for (int i = 0, y = t * 4; i < 4 && y < height; i++, y++)
					Buffer.BlockCopy(buffer, i * 4 * 4, pixels, (int)((y * width + s * 4) * 4), (int)clen);
			}
		}
	}

	private static void Rgb565To888(ushort c, out byte r, out byte g, out byte b)
	{
		r = (byte)(((c & 0xf800) >> 8) | ((c & 0xf800) >> 13));
		g = (byte)(((c & 0x07e0) >> 3) | ((c & 0x07e0) >> 9));
		b = (byte)(((c & 0x001f) << 3) | ((c & 0x001f) >> 2));
	}

	private static uint Color(byte r, byte g, byte b, byte a)
	{
		return ((uint)a << 24) | ((uint)b << 16) | ((uint)g << 8) | r;
	}
}
