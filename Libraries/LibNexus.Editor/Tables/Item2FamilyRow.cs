using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Item2FamilyRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("soundEventIdEquip")]
	public uint SoundEventIdEquip { get; set; }

	[Column("vendorMultiplier")]
	public float VendorMultiplier { get; set; }

	[Column("turninMultiplier")]
	public float TurninMultiplier { get; set; }
}
