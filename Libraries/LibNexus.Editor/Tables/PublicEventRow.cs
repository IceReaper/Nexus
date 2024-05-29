using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("worldId")]
	public uint WorldId { get; set; }

	[Column("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("failureTimeMs")]
	public uint FailureTimeMs { get; set; }

	[Column("worldLocation2Id")]
	public uint WorldLocation2Id { get; set; }

	[Column("publicEventTypeEnum")]
	public uint PublicEventTypeEnum { get; set; }

	[Column("publicEventIdParent")]
	public uint PublicEventIdParent { get; set; }

	[Column("minPlayerLevel")]
	public uint MinPlayerLevel { get; set; }

	[Column("liveEventIdLifetime")]
	public uint LiveEventIdLifetime { get; set; }

	[Column("publicEventFlags")]
	public uint PublicEventFlags { get; set; }

	[Column("localizedTextIdEnd")]
	public uint LocalizedTextIdEnd { get; set; }

	[Column("rewardRotationContentId")]
	public uint RewardRotationContentId { get; set; }
}
