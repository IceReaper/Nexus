using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillMaterialRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("item2IdStatRevolution")]
	public uint Item2IdStatRevolution { get; set; }

	[Column("item2Id")]
	public uint Item2Id { get; set; }

	[Column("displayIndex")]
	public uint DisplayIndex { get; set; }

	[Column("tradeskillMaterialCategoryId")]
	public uint TradeskillMaterialCategoryId { get; set; }
}
