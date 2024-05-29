using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingNeighborhoodInfoRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("baseCost")]
	public uint BaseCost { get; set; }

	[Column("maxPopulation")]
	public uint MaxPopulation { get; set; }

	[Column("populationThreshold")]
	public uint PopulationThreshold { get; set; }

	[Column("housingFactionEnum")]
	public uint HousingFactionEnum { get; set; }

	[Column("housingFeatureTypeEnum")]
	public uint HousingFeatureTypeEnum { get; set; }

	[Column("housingPlaystyleTypeEnum")]
	public uint HousingPlaystyleTypeEnum { get; set; }

	[Column("housingMapInfoIdPrimary")]
	public uint HousingMapInfoIdPrimary { get; set; }

	[Column("housingMapInfoIdSecondary")]
	public uint HousingMapInfoIdSecondary { get; set; }
}
