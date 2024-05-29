using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CityDirectionRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("cityDirectionTypeEnum")]
	public uint CityDirectionTypeEnum { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[Column("worldLocation2Id00")]
	public uint WorldLocation2Id00 { get; set; }

	[Column("worldLocation2Id01")]
	public uint WorldLocation2Id01 { get; set; }

	[Column("worldLocation2Id02")]
	public uint WorldLocation2Id02 { get; set; }

	[Column("worldLocation2Id03")]
	public uint WorldLocation2Id03 { get; set; }
}
