using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Creature2ActionRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("description")]
	public string Description { get; set; } = string.Empty;

	[Column("creatureActionSetId")]
	public uint CreatureActionSetId { get; set; }

	[Column("state")]
	public uint State { get; set; }

	[Column("event")]
	public uint Event { get; set; }

	[Column("orderIndex")]
	public uint OrderIndex { get; set; }

	[Column("delayMS")]
	public uint DelayMs { get; set; }

	[Column("action")]
	public uint Action { get; set; }

	[Column("actionData00")]
	public uint ActionData00 { get; set; }

	[Column("actionData01")]
	public uint ActionData01 { get; set; }

	[Column("visualEffectId")]
	public uint VisualEffectId { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }
}
