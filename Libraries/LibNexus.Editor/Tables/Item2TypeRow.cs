using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Item2TypeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("itemSlotId")]
	public uint ItemSlotId { get; set; }

	[Column("soundEventIdLoot")]
	public uint SoundEventIdLoot { get; set; }

	[Column("soundEventIdEquip")]
	public uint SoundEventIdEquip { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("vendorMultiplier")]
	public float VendorMultiplier { get; set; }

	[Column("turninMultiplier")]
	public float TurninMultiplier { get; set; }

	[Column("Item2CategoryId")]
	public uint Item2CategoryId { get; set; }

	[Column("referenceMuzzleX")]
	public float ReferenceMuzzleX { get; set; }

	[Column("referenceMuzzleY")]
	public float ReferenceMuzzleY { get; set; }

	[Column("referenceMuzzleZ")]
	public float ReferenceMuzzleZ { get; set; }
}
