using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemRuneSlotRandomizationRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("microchipTypeEnum")]
	public uint MicrochipTypeEnum { get; set; }

	[Column("itemRoleFlagBitMask")]
	public uint ItemRoleFlagBitMask { get; set; }

	[Column("randomWeight")]
	public float RandomWeight { get; set; }
}
