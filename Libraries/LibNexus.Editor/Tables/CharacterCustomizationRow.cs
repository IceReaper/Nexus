using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CharacterCustomizationRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("raceId")]
	public uint RaceId { get; set; }

	[Column("gender")]
	public uint Gender { get; set; }

	[Column("itemSlotId")]
	public uint ItemSlotId { get; set; }

	[Column("itemDisplayId")]
	public uint ItemDisplayId { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("characterCustomizationLabelId00")]
	public uint CharacterCustomizationLabelId00 { get; set; }

	[Column("characterCustomizationLabelId01")]
	public uint CharacterCustomizationLabelId01 { get; set; }

	[Column("value00")]
	public uint Value00 { get; set; }

	[Column("value01")]
	public uint Value01 { get; set; }
}
