using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingPlugItemRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("housingPlotTypeId")]
	public uint HousingPlotTypeId { get; set; }

	[Column("localizedTextIdTooltip")]
	public uint LocalizedTextIdTooltip { get; set; }

	[Column("worldIdPlug00")]
	public uint WorldIdPlug00 { get; set; }

	[Column("worldIdPlug01")]
	public uint WorldIdPlug01 { get; set; }

	[Column("worldIdPlug02")]
	public uint WorldIdPlug02 { get; set; }

	[Column("worldIdPlug03")]
	public uint WorldIdPlug03 { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("housingResourceIdProvided00")]
	public uint HousingResourceIdProvided00 { get; set; }

	[Column("housingResourceIdProvided01")]
	public uint HousingResourceIdProvided01 { get; set; }

	[Column("housingResourceIdProvided02")]
	public uint HousingResourceIdProvided02 { get; set; }

	[Column("housingResourceIdProvided03")]
	public uint HousingResourceIdProvided03 { get; set; }

	[Column("housingResourceIdProvided04")]
	public uint HousingResourceIdProvided04 { get; set; }

	[Column("housingResourceIdPrerequisite00")]
	public uint HousingResourceIdPrerequisite00 { get; set; }

	[Column("housingResourceIdPrerequisite01")]
	public uint HousingResourceIdPrerequisite01 { get; set; }

	[Column("housingResourceIdPrerequisite02")]
	public uint HousingResourceIdPrerequisite02 { get; set; }

	[Column("housingFeatureTypeFlags")]
	public uint HousingFeatureTypeFlags { get; set; }

	[Column("housingContributionInfoId00")]
	public uint HousingContributionInfoId00 { get; set; }

	[Column("housingContributionInfoId01")]
	public uint HousingContributionInfoId01 { get; set; }

	[Column("housingContributionInfoId02")]
	public uint HousingContributionInfoId02 { get; set; }

	[Column("housingContributionInfoId03")]
	public uint HousingContributionInfoId03 { get; set; }

	[Column("housingContributionInfoId04")]
	public uint HousingContributionInfoId04 { get; set; }

	[Column("housingPlugItemIdNextUpgrade")]
	public uint HousingPlugItemIdNextUpgrade { get; set; }

	[Column("localizedTextIdPrereqTooltip00")]
	public uint LocalizedTextIdPrereqTooltip00 { get; set; }

	[Column("localizedTextIdPrereqTooltip01")]
	public uint LocalizedTextIdPrereqTooltip01 { get; set; }

	[Column("localizedTextIdPrereqTooltip02")]
	public uint LocalizedTextIdPrereqTooltip02 { get; set; }

	[Column("prerequisiteId00")]
	public uint PrerequisiteId00 { get; set; }

	[Column("prerequisiteId01")]
	public uint PrerequisiteId01 { get; set; }

	[Column("prerequisiteId02")]
	public uint PrerequisiteId02 { get; set; }

	[Column("prerequisiteIdUnlock")]
	public uint PrerequisiteIdUnlock { get; set; }

	[Column("housingBuildId")]
	public uint HousingBuildId { get; set; }

	[Column("housingUpkeepTypeEnum")]
	public uint HousingUpkeepTypeEnum { get; set; }

	[Column("upkeepCharges")]
	public uint UpkeepCharges { get; set; }

	[Column("upkeepTime")]
	public float UpkeepTime { get; set; }

	[Column("housingContributionInfoIdUpkeepCost00")]
	public uint HousingContributionInfoIdUpkeepCost00 { get; set; }

	[Column("housingContributionInfoIdUpkeepCost01")]
	public uint HousingContributionInfoIdUpkeepCost01 { get; set; }

	[Column("housingContributionInfoIdUpkeepCost02")]
	public uint HousingContributionInfoIdUpkeepCost02 { get; set; }

	[Column("housingContributionInfoIdUpkeepCost03")]
	public uint HousingContributionInfoIdUpkeepCost03 { get; set; }

	[Column("housingContributionInfoIdUpkeepCost04")]
	public uint HousingContributionInfoIdUpkeepCost04 { get; set; }

	[Column("gameFormulaIdHousingBuildBonus")]
	public uint GameFormulaIdHousingBuildBonus { get; set; }

	[Column("screenshotSprite00")]
	public string ScreenshotSprite00 { get; set; } = string.Empty;

	[Column("screenshotSprite01")]
	public string ScreenshotSprite01 { get; set; } = string.Empty;

	[Column("screenshotSprite02")]
	public string ScreenshotSprite02 { get; set; } = string.Empty;

	[Column("screenshotSprite03")]
	public string ScreenshotSprite03 { get; set; } = string.Empty;

	[Column("screenshotSprite04")]
	public string ScreenshotSprite04 { get; set; } = string.Empty;

	[Column("housingPlugTypeEnum")]
	public uint HousingPlugTypeEnum { get; set; }

	[Column("accountItemIdUpsell")]
	public uint AccountItemIdUpsell { get; set; }
}
