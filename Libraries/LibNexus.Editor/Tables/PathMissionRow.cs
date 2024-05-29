using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathMissionRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("creature2IdUnlock")]
	public uint Creature2IdUnlock { get; set; }

	[Column("pathTypeEnum")]
	public uint PathTypeEnum { get; set; }

	[Column("pathMissionTypeEnum")]
	public uint PathMissionTypeEnum { get; set; }

	[Column("pathMissionDisplayTypeEnum")]
	public uint PathMissionDisplayTypeEnum { get; set; }

	[Column("objectId")]
	public uint ObjectId { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdSummary")]
	public uint LocalizedTextIdSummary { get; set; }

	[Column("pathEpisodeId")]
	public uint PathEpisodeId { get; set; }

	[Column("worldLocation2Id00")]
	public uint WorldLocation2Id00 { get; set; }

	[Column("worldLocation2Id01")]
	public uint WorldLocation2Id01 { get; set; }

	[Column("worldLocation2Id02")]
	public uint WorldLocation2Id02 { get; set; }

	[Column("worldLocation2Id03")]
	public uint WorldLocation2Id03 { get; set; }

	[Column("pathMissionFlags")]
	public uint PathMissionFlags { get; set; }

	[Column("pathMissionFactionEnum")]
	public uint PathMissionFactionEnum { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[Column("localizedTextIdCommunicator")]
	public uint LocalizedTextIdCommunicator { get; set; }

	[Column("localizedTextIdUnlock")]
	public uint LocalizedTextIdUnlock { get; set; }

	[Column("localizedTextIdSoldierOrders")]
	public uint LocalizedTextIdSoldierOrders { get; set; }

	[Column("creature2IdContactOverride")]
	public uint Creature2IdContactOverride { get; set; }

	[Column("questDirectionId")]
	public uint QuestDirectionId { get; set; }
}
