using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class EldanAugmentationCategoryRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("eldanAugmentationCategoryIdTier2Category00")]
	public uint EldanAugmentationCategoryIdTier2Category00 { get; set; }

	[Column("eldanAugmentationCategoryIdTier2Category01")]
	public uint EldanAugmentationCategoryIdTier2Category01 { get; set; }

	[Column("tier2CostAmount00")]
	public uint Tier2CostAmount00 { get; set; }

	[Column("tier2CostAmount01")]
	public uint Tier2CostAmount01 { get; set; }

	[Column("tier3CostAmount00")]
	public uint Tier3CostAmount00 { get; set; }

	[Column("tier3CostAmount01")]
	public uint Tier3CostAmount01 { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }
}
