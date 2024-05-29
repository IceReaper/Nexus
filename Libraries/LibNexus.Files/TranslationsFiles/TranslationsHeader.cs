using LibNexus.Core.Extensions;

namespace LibNexus.Files.TranslationsFiles;

public class TranslationsHeader
{
	public uint Id { get; }
	public ulong NameLength { get; }
	public ulong NameOffset { get; }
	public ulong CodeLength { get; }
	public ulong CodeOffset { get; }
	public ulong DescriptionLength { get; }
	public ulong DescriptionOffset { get; }
	public ulong TranslationsAmount { get; set; }
	public ulong TranslationsOffset { get; }
	public ulong StringsWideCharacter { get; set; }
	public ulong StringsOffset { get; set; }

	public TranslationsHeader(Stream stream)
	{
		Id = stream.ReadUInt32();
		stream.ReadUInt32(); // TODO
		NameLength = stream.ReadUInt64();
		NameOffset = stream.ReadUInt64();
		CodeLength = stream.ReadUInt64();
		CodeOffset = stream.ReadUInt64();
		DescriptionLength = stream.ReadUInt64();
		DescriptionOffset = stream.ReadUInt64();
		TranslationsAmount = stream.ReadUInt64();
		TranslationsOffset = stream.ReadUInt64();
		StringsWideCharacter = stream.ReadUInt64();
		StringsOffset = stream.ReadUInt64();
	}
}
