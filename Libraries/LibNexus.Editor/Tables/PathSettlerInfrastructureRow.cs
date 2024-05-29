using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathSettlerInfrastructureRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("pathSettlerHubId00")]
	public uint PathSettlerHubId00 { get; set; }

	[Column("pathSettlerHubId01")]
	public uint PathSettlerHubId01 { get; set; }

	[Column("localizedTextIdObjective")]
	public uint LocalizedTextIdObjective { get; set; }

	[Column("missionCount")]
	public uint MissionCount { get; set; }

	[Column("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[Column("count")]
	public uint Count { get; set; }

	[Column("maxTime")]
	public uint MaxTime { get; set; }

	[Column("creature2IdDepot")]
	public uint Creature2IdDepot { get; set; }

	[Column("creature2IdResource00")]
	public uint Creature2IdResource00 { get; set; }

	[Column("creature2IdResource01")]
	public uint Creature2IdResource01 { get; set; }

	[Column("creature2IdResource02")]
	public uint Creature2IdResource02 { get; set; }

	[Column("spell4IdResource00")]
	public uint Spell4IdResource00 { get; set; }

	[Column("spell4IdResource01")]
	public uint Spell4IdResource01 { get; set; }

	[Column("spell4IdResource02")]
	public uint Spell4IdResource02 { get; set; }

	[Column("maxStackCountResource00")]
	public uint MaxStackCountResource00 { get; set; }

	[Column("maxStackCountResource01")]
	public uint MaxStackCountResource01 { get; set; }

	[Column("maxStackCountResource02")]
	public uint MaxStackCountResource02 { get; set; }
}
