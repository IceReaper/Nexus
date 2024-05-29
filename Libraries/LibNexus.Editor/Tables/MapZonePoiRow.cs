using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MapZonePoiRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("mapZoneId")]
	public uint MapZoneId { get; set; }

	[Column("pos0")]
	public uint Pos0 { get; set; }

	[Column("pos1")]
	public uint Pos1 { get; set; }

	[Column("pos2")]
	public uint Pos2 { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("mapZoneSpriteId")]
	public uint MapZoneSpriteId { get; set; }
}
