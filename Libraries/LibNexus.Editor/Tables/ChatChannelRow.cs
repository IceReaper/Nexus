using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ChatChannelRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("enumName")]
	public string EnumName { get; set; } = string.Empty;

	[Column("universalCommand00")]
	public string UniversalCommand00 { get; set; } = string.Empty;

	[Column("universalCommand01")]
	public string UniversalCommand01 { get; set; } = string.Empty;

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdCommand")]
	public uint LocalizedTextIdCommand { get; set; }

	[Column("localizedTextIdAbbreviation")]
	public uint LocalizedTextIdAbbreviation { get; set; }

	[Column("localizedTextIdAlternate00")]
	public uint LocalizedTextIdAlternate00 { get; set; }

	[Column("localizedTextIdAlternate01")]
	public uint LocalizedTextIdAlternate01 { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }
}
