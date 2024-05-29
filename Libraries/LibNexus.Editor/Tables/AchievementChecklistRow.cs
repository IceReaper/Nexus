using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class AchievementChecklistRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("achievementId")]
	public uint AchievementId { get; set; }

	[Column("bit")]
	public uint Bit { get; set; }

	[Column("objectId")]
	public uint ObjectId { get; set; }

	[Column("objectIdAlt")]
	public uint ObjectIdAlt { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[Column("prerequisiteIdAlt")]
	public uint PrerequisiteIdAlt { get; set; }
}
