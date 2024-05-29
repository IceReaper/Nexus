using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemSetRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("itemSetBonusId00")]
	public uint ItemSetBonusId00 { get; set; }

	[Column("itemSetBonusId01")]
	public uint ItemSetBonusId01 { get; set; }

	[Column("itemSetBonusId02")]
	public uint ItemSetBonusId02 { get; set; }

	[Column("itemSetBonusId03")]
	public uint ItemSetBonusId03 { get; set; }

	[Column("itemSetBonusId04")]
	public uint ItemSetBonusId04 { get; set; }

	[Column("itemSetBonusId05")]
	public uint ItemSetBonusId05 { get; set; }

	[Column("itemSetBonusId06")]
	public uint ItemSetBonusId06 { get; set; }

	[Column("itemSetBonusId07")]
	public uint ItemSetBonusId07 { get; set; }

	[Column("itemSetBonusId08")]
	public uint ItemSetBonusId08 { get; set; }

	[Column("itemSetBonusId09")]
	public uint ItemSetBonusId09 { get; set; }

	[Column("itemSetBonusId10")]
	public uint ItemSetBonusId10 { get; set; }

	[Column("itemSetBonusId11")]
	public uint ItemSetBonusId11 { get; set; }
}
