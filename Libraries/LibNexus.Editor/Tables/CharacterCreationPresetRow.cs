using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CharacterCreationPresetRow
{
	[Column("id")]
	public uint Id { get; set; }

	[Column("raceId")]
	public uint RaceId { get; set; }

	[Column("faction2Id")]
	public uint Faction2Id { get; set; }

	[Column("gender")]
	public uint Gender { get; set; }

	[Column("stringPreset")]
	public string StringPreset { get; set; } = string.Empty;
}
