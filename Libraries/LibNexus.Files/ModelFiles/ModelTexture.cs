using LibNexus.Core.Extensions;

namespace LibNexus.Files.ModelFiles;

public class ModelTexture
{
	public const ulong Size = 32;

	public ulong FileLength { get; }
	public ulong FileOffset { get; }

	public ModelTexture(Stream stream)
	{
		stream.ReadBytes(16); // TODO
		FileLength = stream.ReadUInt64();
		FileOffset = stream.ReadUInt64();
	}
}
