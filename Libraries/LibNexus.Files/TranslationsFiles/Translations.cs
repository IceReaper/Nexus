using LibNexus.Core.Extensions;
using LibNexus.Core.Streams;

namespace LibNexus.Files.TranslationsFiles;

public class Translations
{
	private static readonly Identifier Identifier = new("LTEX", 4);

	public string Name { get; }
	public string Code { get; }
	public string Description { get; }

	public Dictionary<uint, string> Strings { get; } = [];

	public Translations(Stream stream)
	{
		FileFormatException.ThrowIf<Translations>(nameof(Identifier), new Identifier(stream) != Identifier);
		var header = new TranslationsHeader(stream);
		using var data = new SegmentStream(stream, Identifier.Size + TranslationsHeader.Size, stream.Length - Identifier.Size - TranslationsHeader.Size, true);

		FileFormatException.ThrowIf<Translations>(nameof(header.NameOffset), (ulong)data.Position != header.NameOffset);
		Name = data.ReadWideString(header.NameLength);
		data.SkipPadding(16);

		FileFormatException.ThrowIf<Translations>(nameof(header.CodeOffset), (ulong)data.Position != header.CodeOffset);
		Code = data.ReadWideString(header.CodeLength);
		data.SkipPadding(16);

		FileFormatException.ThrowIf<Translations>(nameof(header.DescriptionOffset), (ulong)data.Position != header.DescriptionOffset);
		Description = data.ReadWideString(header.DescriptionLength);
		data.SkipPadding(16);

		FileFormatException.ThrowIf<Translations>(nameof(header.TranslationsOffset), (ulong)data.Position != header.TranslationsOffset);
		data.Position += (long)(header.TranslationsAmount * 8);
		data.SkipPadding(16);

		FileFormatException.ThrowIf<Translations>(nameof(header.CharactersOffset), (ulong)data.Position != header.CharactersOffset);
		var strings = new Dictionary<ulong, string>();

		while ((ulong)data.Position < header.CharactersOffset + header.CharactersAmount * 2)
			strings.Add((ulong)((data.Position - (long)header.CharactersOffset) / 2), data.ReadWideString());

		data.SkipPadding(16);

		FileFormatException.ThrowIf<Translations>(nameof(data), data.Position != data.Length);

		data.Position = (long)header.TranslationsOffset;

		for (var i = 0UL; i < header.TranslationsAmount; i++)
			Strings.Add(data.ReadUInt32(), strings[data.ReadUInt32()]);
	}
}
