using LibNexus.Core.Extensions;

namespace LibNexus.Files.ModelFiles;

public class ModelMaterialHeader
{
	public const ulong Size = 48;

	public uint DataOffset { get; }

	public ModelMaterialHeader(Stream stream)
	{
		stream.ReadBytes(40); // TODO
		DataOffset = stream.ReadUInt32();
		stream.ReadBytes(4); // TODO
	}
}
