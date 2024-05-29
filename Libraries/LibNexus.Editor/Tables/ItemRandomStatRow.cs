using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemRandomStatRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("itemRandomStatGroupId")]
	public uint ItemRandomStatGroupId { get; set; }

	[Column("weight")]
	public float Weight { get; set; }

	[Column("itemStatTypeEnum")]
	public uint ItemStatTypeEnum { get; set; }

	[Column("itemStatData")]
	public uint ItemStatData { get; set; }
}
