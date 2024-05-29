using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("tutorialId")]
	public uint TutorialId { get; set; }

	[Column("achievementCategoryId")]
	public uint AchievementCategoryId { get; set; }

	[Column("maxAdditives")]
	public uint MaxAdditives { get; set; }

	[Column("localizedTextIdAxisName00")]
	public uint LocalizedTextIdAxisName00 { get; set; }

	[Column("localizedTextIdAxisName01")]
	public uint LocalizedTextIdAxisName01 { get; set; }

	[Column("localizedTextIdAxisName02")]
	public uint LocalizedTextIdAxisName02 { get; set; }

	[Column("localizedTextIdAxisName03")]
	public uint LocalizedTextIdAxisName03 { get; set; }
}
