using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class EldanAugmentationRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("displayRow")]
	public uint DisplayRow { get; set; }

	[Column("displayColumn")]
	public uint DisplayColumn { get; set; }

	[Column("classId")]
	public uint ClassId { get; set; }

	[Column("powerCost")]
	public uint PowerCost { get; set; }

	[Column("eldanAugmentationIdRequired")]
	public uint EldanAugmentationIdRequired { get; set; }

	[Column("spell4IdAugment")]
	public uint Spell4IdAugment { get; set; }

	[Column("item2IdUnlock")]
	public uint Item2IdUnlock { get; set; }

	[Column("eldanAugmentationCategoryId")]
	public uint EldanAugmentationCategoryId { get; set; }

	[Column("categoryTier")]
	public uint CategoryTier { get; set; }

	[Column("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[Column("localizedTextIdTooltip")]
	public uint LocalizedTextIdTooltip { get; set; }
}
