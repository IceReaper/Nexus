using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class XpPerLevelRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("minXpForLevel")]
	public uint MinXpForLevel { get; set; }

	[Column("baseQuestXpPerLevel")]
	public uint BaseQuestXpPerLevel { get; set; }

	[Column("abilityPointsPerLevel")]
	public uint AbilityPointsPerLevel { get; set; }

	[Column("attributePointsPerLevel")]
	public uint AttributePointsPerLevel { get; set; }

	[Column("baseRepRewardPerLevel")]
	public uint BaseRepRewardPerLevel { get; set; }
}
