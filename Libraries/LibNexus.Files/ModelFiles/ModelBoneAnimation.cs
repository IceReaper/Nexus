using LibNexus.Core.Extensions;

namespace LibNexus.Files.ModelFiles;

public class ModelBoneAnimation
{
	public ModelBoneAnimation(Stream stream, ModelBoneHeader header)
	{
		if (header.Animation1Entries != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(header.Animation1TimeOffset), stream.Position != (long)header.Animation1TimeOffset);
			stream.ReadBytes(header.Animation1Entries * 4); // TODO
			stream.SkipPadding(16);

			FileFormatException.ThrowIf<Model>(nameof(header.Animation1ValueOffset), stream.Position != (long)header.Animation1ValueOffset);
			stream.ReadBytes(header.Animation1Entries * 6); // TODO
			stream.SkipPadding(16);
		}

		FileFormatException.ThrowIf<Model>(nameof(header.Animation2Entries), header.Animation2Entries != 0);
		FileFormatException.ThrowIf<Model>(nameof(header.Animation3Entries), header.Animation3Entries != 0);
		FileFormatException.ThrowIf<Model>(nameof(header.Animation4Entries), header.Animation4Entries != 0);

		if (header.Animation5Entries != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(header.Animation5TimeOffset), stream.Position != (long)header.Animation5TimeOffset);
			stream.ReadBytes(header.Animation5Entries * 4); // TODO
			stream.SkipPadding(16);

			FileFormatException.ThrowIf<Model>(nameof(header.Animation5ValueOffset), stream.Position != (long)header.Animation5ValueOffset);
			stream.ReadBytes(header.Animation5Entries * 8); // TODO
			stream.SkipPadding(16);
		}

		FileFormatException.ThrowIf<Model>(nameof(header.Animation6Entries), header.Animation6Entries != 0);

		if (header.Animation7Entries != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(header.Animation7TimeOffset), stream.Position != (long)header.Animation7TimeOffset);
			stream.ReadBytes(header.Animation7Entries * 4); // TODO
			stream.SkipPadding(16);

			FileFormatException.ThrowIf<Model>(nameof(header.Animation7ValueOffset), stream.Position != (long)header.Animation7ValueOffset);
			stream.ReadBytes(header.Animation7Entries * 12); // TODO
			stream.SkipPadding(16);
		}

		FileFormatException.ThrowIf<Model>(nameof(header.Animation8Entries), header.Animation8Entries != 0);
	}
}
