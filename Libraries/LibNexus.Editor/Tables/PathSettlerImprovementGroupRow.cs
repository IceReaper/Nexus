using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathSettlerImprovementGroupRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("pathSettlerHubId")]
	public uint PathSettlerHubId { get; set; }

	[Column("pathSettlerImprovementGroupFlags")]
	public uint PathSettlerImprovementGroupFlags { get; set; }

	[Column("creature2IdDepot")]
	public uint Creature2IdDepot { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("settlerAvenueTypeEnum")]
	public uint SettlerAvenueTypeEnum { get; set; }

	[Column("contributionValue")]
	public uint ContributionValue { get; set; }

	[Column("perTierBonusContributionValue")]
	public uint PerTierBonusContributionValue { get; set; }

	[Column("durationPerBundleMs")]
	public uint DurationPerBundleMs { get; set; }

	[Column("maxBundleCount")]
	public uint MaxBundleCount { get; set; }

	[Column("pathSettlerImprovementGroupIdOutpostRequired")]
	public uint PathSettlerImprovementGroupIdOutpostRequired { get; set; }

	[Column("pathSettlerImprovementIdTier00")]
	public uint PathSettlerImprovementIdTier00 { get; set; }

	[Column("pathSettlerImprovementIdTier01")]
	public uint PathSettlerImprovementIdTier01 { get; set; }

	[Column("pathSettlerImprovementIdTier02")]
	public uint PathSettlerImprovementIdTier02 { get; set; }

	[Column("pathSettlerImprovementIdTier03")]
	public uint PathSettlerImprovementIdTier03 { get; set; }

	[Column("worldLocation2IdDisplayPoint")]
	public uint WorldLocation2IdDisplayPoint { get; set; }
}
