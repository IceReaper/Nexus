using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TargetMarkerRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("visualEffectId")]
	public uint VisualEffectId { get; set; }

	[Column("iconPath")]
	public string IconPath { get; set; } = string.Empty;
}
