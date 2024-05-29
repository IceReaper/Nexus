using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemStatRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("itemStatTypeEnum00")]
	public uint ItemStatTypeEnum00 { get; set; }

	[Column("itemStatTypeEnum01")]
	public uint ItemStatTypeEnum01 { get; set; }

	[Column("itemStatTypeEnum02")]
	public uint ItemStatTypeEnum02 { get; set; }

	[Column("itemStatTypeEnum03")]
	public uint ItemStatTypeEnum03 { get; set; }

	[Column("itemStatTypeEnum04")]
	public uint ItemStatTypeEnum04 { get; set; }

	[Column("itemStatData00")]
	public uint ItemStatData00 { get; set; }

	[Column("itemStatData01")]
	public uint ItemStatData01 { get; set; }

	[Column("itemStatData02")]
	public uint ItemStatData02 { get; set; }

	[Column("itemStatData03")]
	public uint ItemStatData03 { get; set; }

	[Column("itemStatData04")]
	public uint ItemStatData04 { get; set; }
}
