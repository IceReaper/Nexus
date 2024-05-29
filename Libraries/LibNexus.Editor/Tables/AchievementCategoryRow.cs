using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class AchievementCategoryRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("localizedTextIdFullName")]
	public uint LocalizedTextIdFullName { get; set; }

	[Column("achievementCategoryIdParent")]
	public uint AchievementCategoryIdParent { get; set; }
}
