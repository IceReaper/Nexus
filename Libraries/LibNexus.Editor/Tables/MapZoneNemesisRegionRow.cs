using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MapZoneNemesisRegionRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("mapZoneHexGroupId")]
	public uint MapZoneHexGroupId { get; set; }

	[Column("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[Column("faction2Id")]
	public uint Faction2Id { get; set; }
}
