using LibNexus.Core.Extensions;

namespace LibNexus.Files.TranslationsFiles;

public class Translations
{
	private const string Magic = "LTEX";
	private const uint Version = 4;

	private readonly Stream _stream;
	private readonly TranslationsHeader _header;

	public string Name { get; }
	public string Code { get; }
	public string Description { get; }

	public Dictionary<uint, string> Strings { get; } = [];

	public Translations(Stream stream)
	{
		_stream = stream;

		var pack = _stream.ReadWord();
		var version = _stream.ReadUInt32();

		if (pack != Magic)
			throw new Exception("Translation: Invalid magic");

		if (version != Version)
			throw new Exception("Translation: Invalid version");

		_header = new TranslationsHeader(stream);

		var headerSize = (ulong)stream.Position;

		if ((ulong)stream.Position != headerSize + _header.NameOffset)
			throw new Exception("Translation: Invalid name offset");

		Name = stream.ReadWideString();
		SkipPadding();

		if ((ulong)Name.Length != _header.NameLength - 1)
			throw new Exception("Translation: Invalid name length");

		if ((ulong)stream.Position != headerSize + _header.CodeOffset)
			throw new Exception("Translation: Invalid code offset");

		Code = stream.ReadWideString();
		SkipPadding();

		if ((ulong)Code.Length != _header.CodeLength - 1)
			throw new Exception("Translation: Invalid code length");

		if ((ulong)stream.Position != headerSize + _header.DescriptionOffset)
			throw new Exception("Translation: Invalid description offset");

		Description = stream.ReadWideString();
		SkipPadding();

		if ((ulong)Description.Length != _header.DescriptionLength - 1)
			throw new Exception("Translation: Invalid description length");

		var translationsPosition = headerSize + _header.TranslationsOffset;

		if ((ulong)stream.Position != translationsPosition)
			throw new Exception("Translation: Invalid translations offset");

		stream.Position += (long)(_header.TranslationsAmount * 8);
		SkipPadding();

		var stringsPosition = headerSize + _header.StringsOffset;

		if ((ulong)stream.Position != stringsPosition)
			throw new Exception("Translation: Invalid strings offset");

		var strings = new Dictionary<ulong, string>();

		while ((ulong)_stream.Position < stringsPosition + _header.StringsWideCharacter * 2)
			strings.Add((ulong)_stream.Position - stringsPosition, _stream.ReadWideString());

		_stream.Position = (long)translationsPosition;

		for (var i = 0UL; i < _header.TranslationsAmount; i++)
			Strings.Add(_stream.ReadUInt32(), strings[_stream.ReadUInt32() * 2]);
	}

	private void SkipPadding()
	{
		if (_stream.Position % 16 != 0)
			_stream.Position += 16 - _stream.Position % 16;
	}
}
