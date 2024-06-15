using LibNexus.Core.Extensions;
using LibNexus.Core.Streams;

namespace LibNexus.Files.ModelFiles;

public class ModelMaterialLayer
{
	private sealed record Chunk(bool Active, ulong Offset, ulong LastValue);

	public ModelMaterialLayer(Stream stream)
	{
		var texture1 = stream.ReadUInt16();
		var texture2 = stream.ReadUInt16();
		var unk1 = stream.ReadUInt32(); // TODO
		var unk2 = stream.ReadUInt32(); // TODO
		var unk3 = stream.ReadUInt32(); // TODO
		var unk4 = stream.ReadUInt32(); // TODO
		var unk5 = stream.ReadUInt32(); // TODO

		var chunks = new Chunk[11];

		for (var i = 0; i < 11; i++)
			chunks[i] = new Chunk(stream.ReadUInt64() == 1, stream.ReadUInt64(), stream.ReadUInt64());

		var unk6 = stream.ReadUInt32(); // TODO
		var unk7 = stream.ReadUInt32(); // TODO

		var chunkStream = new SegmentStream(stream);

		foreach (var chunk in chunks)
		{
			if (!chunk.Active)
				continue;

			chunkStream.ReadBytes((chunk.LastValue - chunk.Offset) * 2); // TODO
			stream.SkipPadding(16);
		}
	}
}
