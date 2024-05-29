using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ClientEventRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("description")]
	public string Description { get; set; } = string.Empty;

	[Column("worldId")]
	public uint WorldId { get; set; }

	[Column("eventTypeEnum")]
	public uint EventTypeEnum { get; set; }

	[Column("eventData")]
	public uint EventData { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[Column("priority")]
	public uint Priority { get; set; }

	[Column("delayMS")]
	public uint DelayMs { get; set; }

	[Column("clientEventActionId")]
	public uint ClientEventActionId { get; set; }
}
