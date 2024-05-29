using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventCustomStatRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("publicEventTypeEnum")]
	public uint PublicEventTypeEnum { get; set; }

	[Column("publicEventId")]
	public uint PublicEventId { get; set; }

	[Column("statIndex")]
	public uint StatIndex { get; set; }

	[Column("localizedTextIdStatName")]
	public uint LocalizedTextIdStatName { get; set; }

	[Column("iconPath")]
	public string IconPath { get; set; } = string.Empty;
}
