using LibNexus.Core.Extensions;
using LibNexus.Core.Streams;

namespace LibNexus.Files.ModelFiles;

public class ModelGeometry
{
	public ModelGeometryVertex[] Vertices { get; }
	public uint[] Indices { get; }
	public ModelGeometryMesh[] Meshes { get; set; }

	private readonly ModelGeometryHeader _header;

	public ModelGeometry(Stream stream)
	{
		_header = new ModelGeometryHeader(stream);
		stream.SkipPadding(16);

		using var dataStream = new SegmentStream(stream);

		Vertices = ReadVertices(dataStream);
		Indices = ReadIndices(dataStream);
		Meshes = ReadMeshes(dataStream);

		if (_header.Unk5Count != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(_header.Unk5Offset), dataStream.Position != (long)_header.Unk5Offset);
			dataStream.ReadBytes(_header.Unk5Count * 4); // TODO
			dataStream.SkipPadding(16);
		}

		if (_header.Unk6Count != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(_header.Unk6Offset), dataStream.Position != (long)_header.Unk6Offset);
			dataStream.ReadBytes(_header.Unk6Count * 2); // TODO
			dataStream.SkipPadding(16);
		}

		// TODO as soon as we know what the hell this is, we have a header and several data sections.
		if (_header.Unk7Count != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(_header.Unk7Offset), dataStream.Position != (long)_header.Unk7Offset);

			var unk1 = dataStream.ReadUInt32(); // TODO
			var unk2 = dataStream.ReadUInt32(); // TODO

			if (unk2 == 0)
				dataStream.ReadBytes(14); // TODO
			else
			{
				if (unk2 == 255)
					dataStream.ReadBytes(2352); // TODO wtf? hack for Glue_Screen_001.m3

				var unk3 = dataStream.ReadUInt32(); // TODO
				var unk4 = dataStream.ReadUInt32(); // TODO

				var unk5Count = dataStream.ReadUInt64();
				var unk5Offset = dataStream.ReadUInt64();
				var unk6Count = dataStream.ReadUInt64();
				var unk6Offset = dataStream.ReadUInt64();
				var unk7Count = dataStream.ReadUInt64();
				var unk7Offset = dataStream.ReadUInt64();
				var unk8Count = dataStream.ReadUInt64();
				var unk8Offset = dataStream.ReadUInt64();

				using var dataStream2 = new SegmentStream(dataStream);

				FileFormatException.ThrowIf<Model>(nameof(unk5Offset), dataStream2.Position != (long)unk5Offset);
				var unk5 = dataStream2.ReadBytes(unk5Count * 16); // TODO
				dataStream2.SkipPadding(16);

				FileFormatException.ThrowIf<Model>(nameof(unk6Offset), dataStream2.Position != (long)unk6Offset);
				var unk6 = dataStream2.ReadBytes(unk6Count * 12); // TODO
				dataStream2.SkipPadding(16);

				FileFormatException.ThrowIf<Model>(nameof(unk7Offset), dataStream2.Position != (long)unk7Offset);
				var unk7 = dataStream2.ReadBytes(unk7Count * 4); // TODO
				dataStream2.SkipPadding(16);

				FileFormatException.ThrowIf<Model>(nameof(unk8Offset), dataStream2.Position != (long)unk8Offset);
				var unk8 = dataStream2.ReadBytes(unk8Count * 20); // TODO
				dataStream2.SkipPadding(16);
			}
		}
	}

	private ModelGeometryVertex[] ReadVertices(Stream stream)
	{
		FileFormatException.ThrowIf<Model>(nameof(_header.VertexOffset), stream.Position != (long)_header.VertexOffset);

		var vertices = new ModelGeometryVertex[_header.VertexCount];

		for (var i = 0; i < _header.VertexCount; i++)
			vertices[i] = new ModelGeometryVertex(stream, _header.VertexFlags, _header.VertexFieldTypes);

		stream.SkipPadding(16);

		return vertices;
	}

	private uint[] ReadIndices(Stream stream)
	{
		FileFormatException.ThrowIf<Model>(nameof(_header.IndexOffset), stream.Position != (long)_header.IndexOffset);

		var indices = new uint[_header.IndexCount];

		for (var i = 0; i < _header.IndexCount; i++)
		{
			indices[i] = _header.IndexFormat switch
			{
				ModelGeometryIndexFormat.Short => stream.ReadUInt16(),
				ModelGeometryIndexFormat.Int => stream.ReadUInt32(),
				_ => throw new FileFormatException(typeof(Model), nameof(_header.IndexFormat))
			};
		}

		stream.SkipPadding(16);

		return indices;
	}

	private ModelGeometryMesh[] ReadMeshes(SegmentStream stream)
	{
		FileFormatException.ThrowIf<Model>(nameof(_header.MeshOffset), stream.Position != (long)_header.MeshOffset);

		var meshes = new ModelGeometryMesh[_header.MeshCount];

		for (var i = 0UL; i < _header.MeshCount; i++)
			meshes[i] = new ModelGeometryMesh(stream);

		stream.SkipPadding(16);

		return meshes;
	}
}
