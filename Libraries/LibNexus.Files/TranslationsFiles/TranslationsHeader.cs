using LibNexus.Core.Extensions;

namespace LibNexus.Files.TranslationsFiles;

public class TranslationsHeader
{
	public const uint Size = 88;

	public uint Id { get; }
	public ulong NameLength { get; }
	public ulong NameOffset { get; }
	public ulong CodeLength { get; }
	public ulong CodeOffset { get; }
	public ulong DescriptionLength { get; }
	public ulong DescriptionOffset { get; }
	public ulong TranslationsAmount { get; }
	public ulong TranslationsOffset { get; }
	public ulong CharactersAmount { get; }
	public ulong CharactersOffset { get; }

	public TranslationsHeader(Stream stream)
	{
		Id = stream.ReadUInt32();
		stream.ReadUInt32(); // TODO What is this?!
		NameLength = stream.ReadUInt64();
		NameOffset = stream.ReadUInt64();
		CodeLength = stream.ReadUInt64();
		CodeOffset = stream.ReadUInt64();
		DescriptionLength = stream.ReadUInt64();
		DescriptionOffset = stream.ReadUInt64();
		TranslationsAmount = stream.ReadUInt64();
		TranslationsOffset = stream.ReadUInt64();
		CharactersAmount = stream.ReadUInt64();
		CharactersOffset = stream.ReadUInt64();
	}
}
