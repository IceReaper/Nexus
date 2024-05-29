using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MapZoneHexGroupRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("mapZoneId")]
	public uint MapZoneId { get; set; }
}
