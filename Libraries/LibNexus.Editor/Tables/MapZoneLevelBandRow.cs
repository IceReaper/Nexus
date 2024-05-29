using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MapZoneLevelBandRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("mapZoneHexGroupId")]
	public uint MapZoneHexGroupId { get; set; }

	[Column("levelMin")]
	public uint LevelMin { get; set; }

	[Column("levelMax")]
	public uint LevelMax { get; set; }

	[Column("labelX")]
	public uint LabelX { get; set; }

	[Column("labelZ")]
	public uint LabelZ { get; set; }
}
