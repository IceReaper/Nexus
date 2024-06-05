using LibNexus.Core.Extensions;
using LibNexus.Core.Streams;

namespace LibNexus.Files.TextureFiles;

public class Texture
{
	private static readonly Identifier Identifier = new("\0GFX", 3);

	public TextureImage[] Images { get; }

	public Texture(Stream stream)
	{
		FileFormatException.ThrowIf<Texture>(nameof(Identifier), new Identifier(stream) != Identifier);
		var header = new TextureHeader(stream);
		using var data = new SegmentStream(stream, Identifier.Size + TextureHeader.Size, stream.Length - Identifier.Size - TextureHeader.Size, true);

		Images = new TextureImage[header.Sides * header.Depths];

		var mipMaps = Math.Max(header.MipMaps, 1);

		for (var mipMap = mipMaps - 1; mipMap > 0; mipMap--)
		{
			var factor = 1 << (int)mipMap;
			var mipWidth = (uint)Math.Max(header.Width / factor + (header.Width % factor == 0 ? 0 : 1), 1);
			var mipHeight = (uint)Math.Max(header.Height / factor + (header.Height % factor == 0 ? 0 : 1), 1);

			for (var i = 0; i < header.Depths * header.Sides; i++)
			{
				data.Position += header.Format switch
				{
					0 when header.IsJpg => header.JpgSizes[mipMaps - mipMap - 1],
					0 => mipWidth * mipHeight * 4,
					1 => mipWidth * mipHeight * 4,
					6 => (mipWidth + (4 - mipWidth % 4) % 4) * mipHeight,
					13 => (mipWidth + 3) / 4 * ((mipHeight + 3) / 4) * 8,
					15 => (mipWidth + 3) / 4 * ((mipHeight + 3) / 4) * 16,
					_ => throw new FileFormatException(typeof(Texture), nameof(header.Format))
				};
			}
		}

		for (var i = 0; i < header.Depths * header.Sides; i++)
		{
			Images[i] = new TextureImage(
				header.Width,
				header.Height,
				header.Format switch
				{
					0 when header.IsJpg => TextureJpg.Read(data.ReadBytes(header.JpgSizes[^1]), header.Width, header.Height, header.JpgFormat, header.JpgLayers),
					0 => ReadBgra32(data, header.Width, header.Height),
					1 => ReadBgra32(data, header.Width, header.Height),
					5 => ReadBgra16(data, header.Width, header.Height),
					6 => ReadGrayscale(data, header.Width, header.Height),
					13 => ReadDxt(data, header.Width, header.Height, false),
					15 => ReadDxt(data, header.Width, header.Height, true),
					18 => ReadGarbage(data, header.Width, header.Height),
					_ => throw new FileFormatException(typeof(Texture), nameof(header.Format))
				}
			);
		}

		FileFormatException.ThrowIf<Texture>(nameof(data), data.Position != data.Length);
	}

	private static byte[] ReadGarbage(Stream stream, uint width, uint height)
	{
		var pixels = new byte[width * height * 4];

		// TODO this is simply guessed, as its only used in 2 developer files!
		for (var i = 0; i < width * height; i++)
		{
			var r = stream.ReadUInt16();
			var g = stream.ReadUInt16();
			var b = stream.ReadUInt16();
			var a = stream.ReadUInt16();

			pixels[i * 4 + 0] = (byte)(r >> 8);
			pixels[i * 4 + 1] = (byte)(g >> 8);
			pixels[i * 4 + 2] = (byte)(b >> 8);
			pixels[i * 4 + 3] = (byte)(a >> 8);
		}

		return pixels;
	}

	private static byte[] ReadBgra32(Stream stream, uint width, uint height)
	{
		var pixels = new byte[width * height * 4];

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

		return pixels;
	}

	private static byte[] ReadBgra16(Stream stream, uint width, uint height)
	{
		var pixels = new byte[width * height * 4];

		for (var i = 0; i < width * height; i++)
		{
			var bg = stream.ReadUInt8();
			var ra = stream.ReadUInt8();

			pixels[i * 4 + 0] = (byte)(((ra & 0xF0) << 0) | ((ra & 0xF0) << 4));
			pixels[i * 4 + 1] = (byte)(((bg & 0x0F) << 0) | ((bg & 0x0F) << 4));
			pixels[i * 4 + 2] = (byte)(((bg & 0xF0) << 0) | ((bg & 0xF0) << 4));
			pixels[i * 4 + 3] = (byte)(((ra & 0x0F) << 0) | ((ra & 0x0F) << 4));
		}

		return pixels;
	}

	private static byte[] ReadGrayscale(Stream stream, uint width, uint height)
	{
		var pixels = new byte[width * height * 4];
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

		return pixels;
	}

	private static byte[] ReadDxt(Stream stream, uint width, uint height, bool alpha)
	{
		var blocksX = (width + 3) / 4;
		var blocksY = (height + 3) / 4;

		var buffer = new uint[16];
		var colors = new uint[4];
		var alphas = new uint[8];
		var pixels = new byte[width * height * 4];

		for (var blockY = 0; blockY < blocksY; blockY++)
		{
			for (var blockX = 0; blockX < blocksX; blockX++)
			{
				var da = 0UL;

				if (alpha)
				{
					alphas[0] = stream.ReadUInt8();
					alphas[1] = stream.ReadUInt8();

					if (alphas[0] > alphas[1])
					{
						alphas[2] = (alphas[0] * 6 + alphas[1] * 1) / 7;
						alphas[3] = (alphas[0] * 5 + alphas[1] * 2) / 7;
						alphas[4] = (alphas[0] * 4 + alphas[1] * 3) / 7;
						alphas[5] = (alphas[0] * 3 + alphas[1] * 4) / 7;
						alphas[6] = (alphas[0] * 2 + alphas[1] * 5) / 7;
						alphas[7] = (alphas[0] * 1 + alphas[1] * 6) / 7;
					}
					else
					{
						alphas[2] = (alphas[0] * 4 + alphas[1] * 1) / 5;
						alphas[3] = (alphas[0] * 3 + alphas[1] * 2) / 5;
						alphas[4] = (alphas[0] * 2 + alphas[1] * 3) / 5;
						alphas[5] = (alphas[0] * 1 + alphas[1] * 4) / 5;
						alphas[7] = 255;
					}

					for (var i = 0; i < 8; i++)
						alphas[i] <<= 24;

					da = stream.ReadUInt32() | ((ulong)stream.ReadUInt16() << 32);
				}
				else
					alphas[0] = 0xFF000000;

				var color1 = stream.ReadUInt16();
				var color2 = stream.ReadUInt16();
				var dc = stream.ReadUInt32();

				var r0 = (byte)(((color1 & 0xf800) >> 8) | ((color1 & 0xf800) >> 13));
				var g0 = (byte)(((color1 & 0x07e0) >> 3) | ((color1 & 0x07e0) >> 9));
				var b0 = (byte)(((color1 & 0x001f) << 3) | ((color1 & 0x001f) >> 2));

				var r1 = (byte)(((color2 & 0xf800) >> 8) | ((color2 & 0xf800) >> 13));
				var g1 = (byte)(((color2 & 0x07e0) >> 3) | ((color2 & 0x07e0) >> 9));
				var b1 = (byte)(((color2 & 0x001f) << 3) | ((color2 & 0x001f) >> 2));

				colors[0] = ((uint)b0 << 16) | ((uint)g0 << 8) | r0;
				colors[1] = ((uint)b1 << 16) | ((uint)g1 << 8) | r1;

				if (color1 > color2)
				{
					colors[2] = ((uint)((b0 * 2 + b1) / 3) << 16) | ((uint)((g0 * 2 + g1) / 3) << 8) | (uint)((r0 * 2 + r1) / 3);
					colors[3] = ((uint)((b0 + b1 * 2) / 3) << 16) | ((uint)((g0 + g1 * 2) / 3) << 8) | (uint)((r0 + r1 * 2) / 3);
				}
				else
					colors[2] = ((uint)((b0 + b1) / 2) << 16) | ((uint)((g0 + g1) / 2) << 8) | (uint)((r0 + r1) / 2);

				for (var i = 0; i < 16; i++, da >>= 3, dc >>= 2)
					buffer[i] = alphas[da & 7] | colors[dc & 3];

				var count = (blockX < blocksX - 1 ? 4 : (width + 3) % 4 + 1) * 4;

				for (int i = 0, y = blockY * 4; i < 4 && y < height; i++, y++)
					Buffer.BlockCopy(buffer, i * 4 * 4, pixels, (int)((y * width + blockX * 4) * 4), (int)count);
			}
		}

		return pixels;
	}
}
