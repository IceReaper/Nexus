using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TrackingSlotRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdLabel")]
	public uint LocalizedTextIdLabel { get; set; }

	[Column("iconPath")]
	public string IconPath { get; set; } = string.Empty;

	[Column("publicEventObjectiveId")]
	public uint PublicEventObjectiveId { get; set; }
}
