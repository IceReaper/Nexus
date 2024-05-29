using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathExplorerDoorRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("worldZoneIdInsideMicro")]
	public uint WorldZoneIdInsideMicro { get; set; }

	[Column("targetGroupIdActivate")]
	public uint TargetGroupIdActivate { get; set; }

	[Column("targetGroupIdKill")]
	public uint TargetGroupIdKill { get; set; }
}
