using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingResidenceInfoRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("housingDecorInfoIdDefaultRoof")]
	public uint HousingDecorInfoIdDefaultRoof { get; set; }

	[Column("housingDecorInfoIdDefaultEntryway")]
	public uint HousingDecorInfoIdDefaultEntryway { get; set; }

	[Column("housingDecorInfoIdDefaultDoor")]
	public uint HousingDecorInfoIdDefaultDoor { get; set; }

	[Column("housingWallpaperInfoIdDefault")]
	public uint HousingWallpaperInfoIdDefault { get; set; }

	[Column("worldLocation2IdInside00")]
	public uint WorldLocation2IdInside00 { get; set; }

	[Column("worldLocation2IdInside01")]
	public uint WorldLocation2IdInside01 { get; set; }

	[Column("worldLocation2IdInside02")]
	public uint WorldLocation2IdInside02 { get; set; }

	[Column("worldLocation2IdInside03")]
	public uint WorldLocation2IdInside03 { get; set; }

	[Column("worldLocation2IdOutside00")]
	public uint WorldLocation2IdOutside00 { get; set; }

	[Column("worldLocation2IdOutside01")]
	public uint WorldLocation2IdOutside01 { get; set; }

	[Column("worldLocation2IdOutside02")]
	public uint WorldLocation2IdOutside02 { get; set; }

	[Column("worldLocation2IdOutside03")]
	public uint WorldLocation2IdOutside03 { get; set; }
}
