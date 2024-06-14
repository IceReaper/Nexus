using LibNexus.Core.Extensions;
using LibNexus.Core.Streams;

namespace LibNexus.Files.ModelFiles;

public class ModelGeometry
{
	public ModelGeometryVertex[] Vertices { get; }
	public uint[] Indices { get; }

	private readonly ModelGeometryHeader _header;

	public ModelGeometry(Stream stream)
	{
		_header = new ModelGeometryHeader(stream);
		stream.SkipPadding(16);

		using var dataStream = new SegmentStream(stream);

		Vertices = ReadVertices(dataStream);
		Indices = ReadIndices(dataStream);

		if (_header.MeshCount != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(_header.MeshOffset), dataStream.Position != (long)_header.MeshOffset);
			dataStream.ReadBytes(_header.MeshCount * 112); // TODO
			dataStream.SkipPadding(16);
		}

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

				var unk5_count = dataStream.ReadUInt64();
				var unk5_offset = dataStream.ReadUInt64();
				var unk6_count = dataStream.ReadUInt64();
				var unk6_offset = dataStream.ReadUInt64();
				var unk7_count = dataStream.ReadUInt64();
				var unk7_offset = dataStream.ReadUInt64();
				var unk8_count = dataStream.ReadUInt64();
				var unk8_offset = dataStream.ReadUInt64();

				using var dataStream2 = new SegmentStream(dataStream);

				FileFormatException.ThrowIf<Model>(nameof(unk5_offset), dataStream2.Position != (long)unk5_offset);
				var unk5 = dataStream2.ReadBytes(unk5_count * 16); // TODO
				dataStream2.SkipPadding(16);

				FileFormatException.ThrowIf<Model>(nameof(unk6_offset), dataStream2.Position != (long)unk6_offset);
				var unk6 = dataStream2.ReadBytes(unk6_count * 12); // TODO
				dataStream2.SkipPadding(16);

				FileFormatException.ThrowIf<Model>(nameof(unk7_offset), dataStream2.Position != (long)unk7_offset);
				var unk7 = dataStream2.ReadBytes(unk7_count * 4); // TODO
				dataStream2.SkipPadding(16);

				FileFormatException.ThrowIf<Model>(nameof(unk8_offset), dataStream2.Position != (long)unk8_offset);
				var unk8 = dataStream2.ReadBytes(unk8_count * 20); // TODO
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
}
