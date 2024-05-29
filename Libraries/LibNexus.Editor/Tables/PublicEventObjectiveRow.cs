using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventObjectiveRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("publicEventId")]
	public uint PublicEventId { get; set; }

	[Column("publicEventObjectiveFlags")]
	public uint PublicEventObjectiveFlags { get; set; }

	[Column("publicEventObjectiveTypeSpecificFlags")]
	public uint PublicEventObjectiveTypeSpecificFlags { get; set; }

	[Column("worldLocation2Id")]
	public uint WorldLocation2Id { get; set; }

	[Column("publicEventTeamId")]
	public uint PublicEventTeamId { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("localizedTextIdOtherTeam")]
	public uint LocalizedTextIdOtherTeam { get; set; }

	[Column("localizedTextIdShort")]
	public uint LocalizedTextIdShort { get; set; }

	[Column("localizedTextIdOtherTeamShort")]
	public uint LocalizedTextIdOtherTeamShort { get; set; }

	[Column("publicEventObjectiveTypeEnum")]
	public uint PublicEventObjectiveTypeEnum { get; set; }

	[Column("count")]
	public uint Count { get; set; }

	[Column("objectId")]
	public uint ObjectId { get; set; }

	[Column("failureTimeMs")]
	public uint FailureTimeMs { get; set; }

	[Column("targetGroupIdRewardPane")]
	public uint TargetGroupIdRewardPane { get; set; }

	[Column("publicEventObjectiveCategoryEnum")]
	public uint PublicEventObjectiveCategoryEnum { get; set; }

	[Column("liveEventIdCounter")]
	public uint LiveEventIdCounter { get; set; }

	[Column("publicEventObjectiveIdParent")]
	public uint PublicEventObjectiveIdParent { get; set; }

	[Column("questDirectionId")]
	public uint QuestDirectionId { get; set; }

	[Column("medalPointValue")]
	public uint MedalPointValue { get; set; }

	[Column("localizedTextIdParticipantAdd")]
	public uint LocalizedTextIdParticipantAdd { get; set; }

	[Column("localizedTextIdStart")]
	public uint LocalizedTextIdStart { get; set; }

	[Column("displayOrder")]
	public uint DisplayOrder { get; set; }
}
