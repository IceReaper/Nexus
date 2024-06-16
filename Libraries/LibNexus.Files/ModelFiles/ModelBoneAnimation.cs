using LibNexus.Core.Extensions;

namespace LibNexus.Files.ModelFiles;

public class ModelBoneAnimation
{
	public ModelBoneAnimation(Stream stream, ModelBone bone)
	{
		if (bone.Animation1Entries != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(bone.Animation1TimeOffset), stream.Position != (long)bone.Animation1TimeOffset);
			stream.ReadBytes(bone.Animation1Entries * 4); // TODO
			stream.SkipPadding(16);

			FileFormatException.ThrowIf<Model>(nameof(bone.Animation1ValueOffset), stream.Position != (long)bone.Animation1ValueOffset);
			stream.ReadBytes(bone.Animation1Entries * 6); // TODO
			stream.SkipPadding(16);
		}

		FileFormatException.ThrowIf<Model>(nameof(bone.Animation2Entries), bone.Animation2Entries != 0);
		FileFormatException.ThrowIf<Model>(nameof(bone.Animation3Entries), bone.Animation3Entries != 0);
		FileFormatException.ThrowIf<Model>(nameof(bone.Animation4Entries), bone.Animation4Entries != 0);

		if (bone.Animation5Entries != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(bone.Animation5TimeOffset), stream.Position != (long)bone.Animation5TimeOffset);
			stream.ReadBytes(bone.Animation5Entries * 4); // TODO
			stream.SkipPadding(16);

			FileFormatException.ThrowIf<Model>(nameof(bone.Animation5ValueOffset), stream.Position != (long)bone.Animation5ValueOffset);
			stream.ReadBytes(bone.Animation5Entries * 8); // TODO
			stream.SkipPadding(16);
		}

		FileFormatException.ThrowIf<Model>(nameof(bone.Animation6Entries), bone.Animation6Entries != 0);

		if (bone.Animation7Entries != 0)
		{
			FileFormatException.ThrowIf<Model>(nameof(bone.Animation7TimeOffset), stream.Position != (long)bone.Animation7TimeOffset);
			stream.ReadBytes(bone.Animation7Entries * 4); // TODO
			stream.SkipPadding(16);

			FileFormatException.ThrowIf<Model>(nameof(bone.Animation7ValueOffset), stream.Position != (long)bone.Animation7ValueOffset);
			stream.ReadBytes(bone.Animation7Entries * 12); // TODO
			stream.SkipPadding(16);
		}

		FileFormatException.ThrowIf<Model>(nameof(bone.Animation8Entries), bone.Animation8Entries != 0);
	}
}
