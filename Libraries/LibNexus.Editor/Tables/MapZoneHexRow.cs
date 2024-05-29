using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MapZoneHexRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("mapZoneId")]
	public uint MapZoneId { get; set; }

	[Column("pos0")]
	public uint Pos0 { get; set; }

	[Column("pos1")]
	public uint Pos1 { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }
}
