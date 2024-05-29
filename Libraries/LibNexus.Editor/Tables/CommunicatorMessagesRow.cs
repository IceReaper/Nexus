using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CommunicatorMessagesRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdMessage")]
	public uint LocalizedTextIdMessage { get; set; }

	[Column("delay")]
	public uint Delay { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("creatureId")]
	public uint CreatureId { get; set; }

	[Column("worldId")]
	public uint WorldId { get; set; }

	[Column("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[Column("minLevel")]
	public uint MinLevel { get; set; }

	[Column("maxLevel")]
	public uint MaxLevel { get; set; }

	[Column("quest00")]
	public uint Quest00 { get; set; }

	[Column("quest01")]
	public uint Quest01 { get; set; }

	[Column("quest02")]
	public uint Quest02 { get; set; }

	[Column("state00")]
	public uint State00 { get; set; }

	[Column("state01")]
	public uint State01 { get; set; }

	[Column("state02")]
	public uint State02 { get; set; }

	[Column("factionId")]
	public uint FactionId { get; set; }

	[Column("classId")]
	public uint ClassId { get; set; }

	[Column("raceId")]
	public uint RaceId { get; set; }

	[Column("factionIdReputation")]
	public uint FactionIdReputation { get; set; }

	[Column("reputationMin")]
	public uint ReputationMin { get; set; }

	[Column("reputationMax")]
	public uint ReputationMax { get; set; }

	[Column("questIdDelivered")]
	public uint QuestIdDelivered { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[Column("displayDuration")]
	public uint DisplayDuration { get; set; }

	[Column("communicatorMessagesIdNext")]
	public uint CommunicatorMessagesIdNext { get; set; }

	[Column("communicatorPortraitPlacementEnum")]
	public uint CommunicatorPortraitPlacementEnum { get; set; }

	[Column("communicatorOverlayEnum")]
	public uint CommunicatorOverlayEnum { get; set; }

	[Column("communicatorBackgroundEnum")]
	public uint CommunicatorBackgroundEnum { get; set; }
}
