using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MatchingGameMapRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("matchingGameMapEnumFlags")]
	public uint MatchingGameMapEnumFlags { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[Column("matchingGameTypeId")]
	public uint MatchingGameTypeId { get; set; }

	[Column("worldId")]
	public uint WorldId { get; set; }

	[Column("recommendedItemLevel")]
	public uint RecommendedItemLevel { get; set; }

	[Column("achievementCategoryId")]
	public uint AchievementCategoryId { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }
}
