using LibNexus.Core.Extensions;

namespace LibNexus.Files.TextureFiles;

public sealed class JpgHeader
{
	public uint Format { get; init; }
	public JpgChannel[] Channels { get; init; }
	public uint[] Sizes { get; init; }

	public JpgHeader(Stream stream)
	{
		Format = stream.ReadUInt32();
		Channels = new JpgChannel[4];

		for (var i = 0; i < Channels.Length; i++)
			Channels[i] = new JpgChannel(stream.ReadUInt8(), stream.ReadUInt8(), stream.ReadUInt8());

		Sizes = new uint[stream.ReadUInt32()];

		for (var i = 0; i < 13; i++)
		{
			var size = stream.ReadUInt32();

			if (i < Sizes.Length)
				Sizes[i] = size;
		}

		if (Format > 2)
			throw new Exception("Texture: Invalid jpg format");
	}
}
