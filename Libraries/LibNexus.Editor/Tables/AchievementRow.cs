using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class AchievementRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("achievementTypeId")]
	public uint AchievementTypeId { get; set; }

	[Column("achievementCategoryId")]
	public uint AchievementCategoryId { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[Column("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[Column("localizedTextIdDesc")]
	public uint LocalizedTextIdDesc { get; set; }

	[Column("localizedTextIdProgress")]
	public uint LocalizedTextIdProgress { get; set; }

	[Column("percCompletionToShow")]
	public float PercCompletionToShow { get; set; }

	[Column("objectId")]
	public uint ObjectId { get; set; }

	[Column("objectIdAlt")]
	public uint ObjectIdAlt { get; set; }

	[Column("value")]
	public uint Value { get; set; }

	[Column("characterTitleId")]
	public uint CharacterTitleId { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[Column("prerequisiteIdServer")]
	public uint PrerequisiteIdServer { get; set; }

	[Column("prerequisiteIdObjective")]
	public uint PrerequisiteIdObjective { get; set; }

	[Column("prerequisiteIdObjectiveAlt")]
	public uint PrerequisiteIdObjectiveAlt { get; set; }

	[Column("achievementIdParentTier")]
	public uint AchievementIdParentTier { get; set; }

	[Column("orderIndex")]
	public uint OrderIndex { get; set; }

	[Column("achievementGroupId")]
	public uint AchievementGroupId { get; set; }

	[Column("achievementSubGroupId")]
	public uint AchievementSubGroupId { get; set; }

	[Column("achievementPointEnum")]
	public uint AchievementPointEnum { get; set; }

	[Column("steamAchievementName")]
	public string SteamAchievementName { get; set; } = string.Empty;
}
