using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MapZoneWorldJoinRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("mapZoneId")]
	public uint MapZoneId { get; set; }

	[Column("worldId")]
	public uint WorldId { get; set; }
}
