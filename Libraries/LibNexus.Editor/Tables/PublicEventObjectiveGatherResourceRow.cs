using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventObjectiveGatherResourceRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("publicEventObjectiveGatherResourceEnumFlag")]
	public uint PublicEventObjectiveGatherResourceEnumFlag { get; set; }

	[Column("creature2IdContainer")]
	public uint Creature2IdContainer { get; set; }

	[Column("creature2IdResource")]
	public uint Creature2IdResource { get; set; }

	[Column("spell4IdResource")]
	public uint Spell4IdResource { get; set; }

	[Column("creature2IdStolenResource")]
	public uint Creature2IdStolenResource { get; set; }

	[Column("spell4IdStolenResource")]
	public uint Spell4IdStolenResource { get; set; }

	[Column("publicEventObjectiveGatherResourceIdOpposing")]
	public uint PublicEventObjectiveGatherResourceIdOpposing { get; set; }
}
