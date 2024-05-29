using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MapZoneHexGroupEntryRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("mapZoneHexGroupId")]
	public uint MapZoneHexGroupId { get; set; }

	[Column("hexX")]
	public uint HexX { get; set; }

	[Column("hexY")]
	public uint HexY { get; set; }
}
