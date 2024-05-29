using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RandomPlayerNameRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("nameFragment")]
	public string NameFragment { get; set; } = string.Empty;

	[Column("nameFragmentTypeEnum")]
	public uint NameFragmentTypeEnum { get; set; }

	[Column("raceId")]
	public uint RaceId { get; set; }

	[Column("gender")]
	public uint Gender { get; set; }

	[Column("faction2Id")]
	public uint Faction2Id { get; set; }

	[Column("languageFlags")]
	public uint LanguageFlags { get; set; }
}
