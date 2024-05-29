using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingPropertyInfoRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("worldId")]
	public uint WorldId { get; set; }

	[Column("housingMapInfoId")]
	public uint HousingMapInfoId { get; set; }

	[Column("cost")]
	public uint Cost { get; set; }

	[Column("housingFacingEnum")]
	public uint HousingFacingEnum { get; set; }

	[Column("worldLocation2Id")]
	public uint WorldLocation2Id { get; set; }

	[Column("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[Column("housingPropertyTypeId")]
	public uint HousingPropertyTypeId { get; set; }

	[Column("worldLayerIdDefault00")]
	public uint WorldLayerIdDefault00 { get; set; }

	[Column("worldLayerIdDefault01")]
	public uint WorldLayerIdDefault01 { get; set; }

	[Column("worldLayerIdDefault02")]
	public uint WorldLayerIdDefault02 { get; set; }

	[Column("worldLayerIdDefault03")]
	public uint WorldLayerIdDefault03 { get; set; }
}
