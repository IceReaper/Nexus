using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillAchievementLayoutRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("achievementId")]
	public uint AchievementId { get; set; }

	[Column("achievementIdParent00")]
	public uint AchievementIdParent00 { get; set; }

	[Column("achievementIdParent01")]
	public uint AchievementIdParent01 { get; set; }

	[Column("achievementIdParent02")]
	public uint AchievementIdParent02 { get; set; }

	[Column("achievementIdParent03")]
	public uint AchievementIdParent03 { get; set; }

	[Column("achievementIdParent04")]
	public uint AchievementIdParent04 { get; set; }

	[Column("gridX")]
	public uint GridX { get; set; }

	[Column("gridY")]
	public uint GridY { get; set; }
}
