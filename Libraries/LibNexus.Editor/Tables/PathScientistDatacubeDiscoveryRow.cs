using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathScientistDatacubeDiscoveryRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("worldZoneId")]
	public uint WorldZoneId { get; set; }
}
