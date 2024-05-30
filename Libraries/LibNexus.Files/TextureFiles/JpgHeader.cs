using LibNexus.Core.Extensions;

namespace LibNexus.Files.TextureFiles;

public sealed class JpgHeader
{
	public uint Format { get; init; }
	public JpgLayer[] Layers { get; init; }
	public uint[] Sizes { get; init; }

	public JpgHeader(Stream stream)
	{
		Format = stream.ReadUInt32();
		Layers = new JpgLayer[4];

		for (var i = 0; i < Layers.Length; i++)
			Layers[i] = new JpgLayer(stream.ReadUInt8(), stream.ReadUInt8(), stream.ReadUInt8());

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
