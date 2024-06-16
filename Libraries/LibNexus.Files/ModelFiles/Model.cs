using LibNexus.Core.Extensions;
using LibNexus.Core.Streams;

namespace LibNexus.Files.ModelFiles;

public class Model
{
	private static readonly Identifier Identifier = new("MODL", 100);

	public ModelBone[] Bones { get; } = [];
	public ModelTexture[] Textures { get; } = [];
	public ModelMaterial[] Materials { get; } = [];
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

		if (_header.Bones.Count != 0)
			Bones = ReadBones(dataStream);

		FileFormatException.ThrowIf<Model>(nameof(_header.Unk26), _header.Unk26.Count != 0);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk27), _header.Unk27.Count != 0);

		if (_header.Unk28.Count != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(_header.Unk28), dataStream.Position != (long)_header.Unk28.Offset);

			for (var i = 0UL; i < _header.Unk28.Count; i++)
				stream.ReadUInt16(); // TODO Bone related?

			dataStream.SkipPadding(16);
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

		if (_header.Unk41.Count != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(_header.Unk41), dataStream.Position != (long)_header.Unk41.Offset);

			for (var i = 0UL; i < _header.Unk41.Count; i++)
				stream.ReadBytes(552); // TODO

			dataStream.SkipPadding(16);
		}

		if (_header.Unk42.Count != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(_header.Unk42), dataStream.Position != (long)_header.Unk42.Offset);

			for (var i = 0UL; i < _header.Unk42.Count; i++)
				stream.ReadBytes(96); // TODO

			dataStream.SkipPadding(16);
		}

		if (_header.Unk43.Count != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(_header.Unk43), dataStream.Position != (long)_header.Unk43.Offset);

			for (var i = 0UL; i < _header.Unk43.Count; i++)
				stream.ReadBytes(4); // TODO

			dataStream.SkipPadding(16);
		}

		if (_header.Unk44.Count != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(_header.Unk44), dataStream.Position != (long)_header.Unk44.Offset);

			var headers = new List<(ulong Count1, ulong Offset1, ulong Count2, ulong Offset2, ulong Count3, ulong Offset3, ulong Count4, ulong Offset4)>();

			for (var i = 0UL; i < _header.Unk44.Count; i++)
			{
				headers.Add(
					(dataStream.ReadUInt64(), dataStream.ReadUInt64(), dataStream.ReadUInt64(), dataStream.ReadUInt64(), dataStream.ReadUInt64(),
						dataStream.ReadUInt64(), dataStream.ReadUInt64(), dataStream.ReadUInt64())
				);

				dataStream.SkipPadding(16);
			}

			using var bodyStream = new SegmentStream(dataStream);

			foreach (var header in headers)
			{
				FileFormatException.ThrowIf<Model>(nameof(header.Offset1), bodyStream.Position != (long)header.Offset1);
				bodyStream.ReadBytes(header.Count1 * 16); // TODO
				bodyStream.SkipPadding(16);

				FileFormatException.ThrowIf<Model>(nameof(header.Offset2), bodyStream.Position != (long)header.Offset2);
				bodyStream.ReadBytes(header.Count2 * 12); // TODO
				bodyStream.SkipPadding(16);

				FileFormatException.ThrowIf<Model>(nameof(header.Offset3), bodyStream.Position != (long)header.Offset3);
				bodyStream.ReadBytes(header.Count3 * 4); // TODO
				bodyStream.SkipPadding(16);

				FileFormatException.ThrowIf<Model>(nameof(header.Offset4), bodyStream.Position != (long)header.Offset4);
				bodyStream.ReadBytes(header.Count4 * 20); // TODO
				bodyStream.SkipPadding(16);
			}
		}

		FileFormatException.ThrowIf<Model>(nameof(_header.Unk45), _header.Unk45.Count != 0);

		FileFormatException.ThrowIf<Model>(nameof(dataStream), dataStream.Position != dataStream.Length);
	}

	private ModelBone[] ReadBones(SegmentStream stream)
	{
		FileFormatException.ThrowIf<Model>(nameof(_header.Bones), stream.Position != (long)_header.Bones.Offset);

		var headers = new ModelBoneHeader[_header.Bones.Count];

		for (var i = 0UL; i < _header.Bones.Count; i++)
		{
			headers[i] = new ModelBoneHeader(stream);
			stream.SkipPadding(16);
		}

		using var animationsStream = new SegmentStream(stream);
		var animations = new ModelBoneAnimation[_header.Bones.Count];

		for (var i = 0UL; i < _header.Bones.Count; i++)
		{
			animations[i] = new ModelBoneAnimation(animationsStream, headers[i]);
			stream.SkipPadding(16);
		}

		return Enumerable.Range(0, (int)_header.Bones.Count).Select(i => new ModelBone(headers[i], animations[i])).ToArray();
	}

	private ModelTexture[] ReadTextures(Stream stream)
	{
		FileFormatException.ThrowIf<Model>(nameof(_header.Textures), stream.Position != (long)_header.Textures.Offset);

		var headers = new ModelTextureHeader[_header.Textures.Count];

		for (var i = 0UL; i < _header.Textures.Count; i++)
		{
			headers[i] = new ModelTextureHeader(stream);
			stream.SkipPadding(16);
		}

		using var texturesStream = new SegmentStream(stream);
		var paths = new Dictionary<ulong, string>();

		for (var i = 0UL; i < _header.Textures.Count; i++)
		{
			paths.Add((ulong)texturesStream.Position, texturesStream.ReadWideString());
			texturesStream.SkipPadding(16);
		}

		return Enumerable.Range(0, (int)_header.Textures.Count).Select(i => new ModelTexture(headers[i], paths[headers[i].FileOffset])).ToArray();
	}

	private ModelMaterial[] ReadMaterials(SegmentStream stream)
	{
		FileFormatException.ThrowIf<Model>(nameof(_header.Materials), stream.Position != (long)_header.Materials.Offset);

		var headers = new ModelMaterialHeader[_header.Materials.Count];

		for (var i = 0UL; i < _header.Materials.Count; i++)
		{
			headers[i] = new ModelMaterialHeader(stream);
			stream.SkipPadding(16);
		}

		using var layersStream = new SegmentStream(stream);

		var layers = new ModelMaterialLayer[_header.Materials.Count][];

		for (var i = 0; i < headers.Length; i++)
		{
			var header = headers[i];

			FileFormatException.ThrowIf<Model>(nameof(header.LayersOffset), layersStream.Position != (long)header.LayersOffset);

			layers[i] = new ModelMaterialLayer[header.Layers];
			var layerHeaders = new ModelMaterialLayerHeader[header.Layers];

			for (var j = 0UL; j < header.Layers; j++)
				layerHeaders[j] = new ModelMaterialLayerHeader(layersStream);

			var chunkStream = new SegmentStream(stream);

			for (var j = 0; j < layerHeaders.Length; j++)
			{
				var layerHeader = layerHeaders[j];
				var datas = new byte[layerHeader.Chunks.Length][];

				for (var k = 0; k < layerHeader.Chunks.Length; k++)
				{
					var chunk = layerHeader.Chunks[k];

					if (!chunk.Active)
						continue;

					FileFormatException.ThrowIf<Model>(nameof(chunk.Offset), chunkStream.Position != (long)chunk.Offset);

					datas[k] = chunkStream.ReadBytes((chunk.LastValue - chunk.Offset) * 2); // TODO
				}

				layers[i][j] = new ModelMaterialLayer(layerHeader, datas);
			}

			layersStream.SkipPadding(16);
		}

		return Enumerable.Range(0, (int)_header.Materials.Count).Select(i => new ModelMaterial(headers[i], layers[i])).ToArray();
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
