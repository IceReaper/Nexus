using LibNexus.Core.Extensions;
using LibNexus.Core.Streams;

namespace LibNexus.Files.ModelFiles;

public class Model
{
	private static readonly Identifier Identifier = new("MODL", 100);

	public (ModelTexture Texture, string File)[] Textures { get; } = [];
	public (ModelMaterialHeader Header, ModelMaterialData Data)[] Materials { get; } = [];
	public ModelGeometry Geometry { get; }

	private readonly ModelHeader _header;

	public Model(Stream stream)
	{
		FileFormatException.ThrowIf<Model>(nameof(Identifier), new Identifier(stream) != Identifier);

		_header = new ModelHeader(stream);

		using var dataStream = new SegmentStream(stream);

		if (_header.Unk2.Count != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(_header.Unk2), dataStream.Position != (long)_header.Unk2.Offset);

			for (var i = 0UL; i < _header.Unk2.Count; i++)
			{
				stream.ReadBytes(112); // TODO
				dataStream.SkipPadding(16);
			}
		}

		FileFormatException.ThrowIf<Model>(nameof(_header.Unk3), _header.Unk3.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk4), _header.Unk4.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk5), _header.Unk5.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk6), _header.Unk6.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk7), _header.Unk7.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk8), _header.Unk8.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk9), _header.Unk9.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk10), _header.Unk10.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk11), _header.Unk11.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk12), _header.Unk12.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk13), _header.Unk13.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk14), _header.Unk14.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk15), _header.Unk15.Count != 0);

		if (_header.Unk16.Count != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(_header.Unk16), dataStream.Position != (long)_header.Unk16.Offset);

			for (var i = 0UL; i < _header.Unk16.Count; i++)
			{
				var unk1 = dataStream.ReadUInt16(); // TODO
				var unk2 = dataStream.ReadUInt16(); // TODO

				dataStream.ReadBytes(unk2 == ushort.MaxValue ? 188 : 204UL); // TODO
				dataStream.SkipPadding(16);
			}
		}

		FileFormatException.ThrowIf<Model>(nameof(_header.Unk17), _header.Unk17.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk18), _header.Unk18.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk19), _header.Unk19.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk20), _header.Unk20.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk21), _header.Unk21.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk22), _header.Unk22.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk23), _header.Unk23.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk24), _header.Unk24.Count != 0);

		if (_header.Unk25.Count != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(_header.Unk25), dataStream.Position != (long)_header.Unk25.Offset);

			for (var i = 0UL; i < _header.Unk25.Count; i++)
			{
				stream.ReadBytes(352); // TODO
				dataStream.SkipPadding(16);
			}
		}

		FileFormatException.ThrowIf<Model>(nameof(_header.Unk26), _header.Unk26.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk27), _header.Unk27.Count != 0);

		if (_header.Unk28.Count != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(_header.Unk28), dataStream.Position != (long)_header.Unk28.Offset);

			for (var i = 0UL; i < _header.Unk28.Count; i++)
			{
				stream.ReadBytes(16); // TODO
				dataStream.SkipPadding(16);
			}
		}

		if (_header.Textures.Count != 0)
			Textures = ReadTextures(dataStream);

		FileFormatException.ThrowIf<Model>(nameof(_header.Unk30), _header.Unk30.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk31), _header.Unk31.Count != 0);

		if (_header.Materials.Count != 0)
			Materials = ReadMaterials(dataStream);

		FileFormatException.ThrowIf<Model>(nameof(_header.Unk33), _header.Unk31.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk34), _header.Unk34.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk35), _header.Unk35.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk36), _header.Unk36.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk37), _header.Unk37.Count != 0);

		FileFormatException.ThrowIf<Model>(nameof(_header.Geometry), _header.Geometry.Count != 1);
		Geometry = ReadGeometry(dataStream);

		if (_header.Unk39.Count != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(_header.Unk39), dataStream.Position != (long)_header.Unk39.Offset);

			for (var i = 0UL; i < _header.Unk39.Count; i++)
			{
				stream.ReadBytes(16); // TODO
				dataStream.SkipPadding(16);
			}
		}

		if (_header.Unk40.Count != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(_header.Unk40), dataStream.Position != (long)_header.Unk40.Offset);

			for (var i = 0UL; i < _header.Unk40.Count; i++)
			{
				stream.ReadBytes(96); // TODO
				dataStream.SkipPadding(16);
			}
		}

		FileFormatException.ThrowIf<Model>(nameof(dataStream), dataStream.Position != dataStream.Length);
	}

	private (ModelTexture Texture, string File)[] ReadTextures(Stream stream)
	{
		FileFormatException.ThrowIf<Model>(nameof(_header.Textures), stream.Position != (long)_header.Textures.Offset);

		var textures = new ModelTexture[_header.Textures.Count];

		for (var i = 0UL; i < _header.Textures.Count; i++)
		{
			textures[i] = new ModelTexture(stream);
			stream.SkipPadding(16);
		}

		using var texturesStream = new SegmentStream(stream);
		var strings = new Dictionary<ulong, string>();

		for (var i = 0UL; i < _header.Textures.Count; i++)
		{
			strings.Add((ulong)texturesStream.Position, texturesStream.ReadWideString());
			texturesStream.SkipPadding(16);
		}

		return textures.Select(texture => (texture, strings[texture.FileOffset])).ToArray();
	}

	private (ModelMaterialHeader Header, ModelMaterialData Data)[] ReadMaterials(SegmentStream stream)
	{
		FileFormatException.ThrowIf<Model>(nameof(_header.Materials), stream.Position != (long)_header.Materials.Offset);

		var materialHeaders = new ModelMaterialHeader[_header.Materials.Count];

		for (var i = 0UL; i < _header.Materials.Count; i++)
		{
			materialHeaders[i] = new ModelMaterialHeader(stream);
			stream.SkipPadding(16);
		}

		using var materialsStream = new SegmentStream(stream);
		var materialData = new Dictionary<uint, ModelMaterialData>();

		for (var i = 0UL; i < _header.Materials.Count; i++)
		{
			materialData.Add((uint)materialsStream.Position, new ModelMaterialData(materialsStream));
			materialsStream.SkipPadding(16);
		}

		return materialHeaders.Select(materialHeader => (materialHeader, materialData[materialHeader.DataOffset])).ToArray();
	}

	private ModelGeometry ReadGeometry(SegmentStream stream)
	{
		FileFormatException.ThrowIf<Model>(nameof(_header.Geometry), stream.Position != (long)_header.Geometry.Offset);

		using var geometryStream = new SegmentStream(stream);

		var geometry = new ModelGeometry(geometryStream);
		geometryStream.SkipPadding(16);

		return geometry;
	}
}
