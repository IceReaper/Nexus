using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CharacterCustomizationLabelRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("faction2Id")]
	public uint Faction2Id { get; set; }

	[Column("displayIndex")]
	public uint DisplayIndex { get; set; }
}
