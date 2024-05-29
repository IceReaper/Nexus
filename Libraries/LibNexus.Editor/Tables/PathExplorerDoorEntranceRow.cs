using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathExplorerDoorEntranceRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("pathExplorerDoorTypeEnumSurface")]
	public uint PathExplorerDoorTypeEnumSurface { get; set; }

	[Column("pathExplorerDoorTypeEnumMicro")]
	public uint PathExplorerDoorTypeEnumMicro { get; set; }

	[Column("creature2IdSurface")]
	public uint Creature2IdSurface { get; set; }

	[Column("creature2IdMicro")]
	public uint Creature2IdMicro { get; set; }

	[Column("pathExplorerDoorId")]
	public uint PathExplorerDoorId { get; set; }

	[Column("worldLocation2IdSurfaceRevealed")]
	public uint WorldLocation2IdSurfaceRevealed { get; set; }
}
