using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingContributionInfoRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("housingContributionTypeId")]
	public uint HousingContributionTypeId { get; set; }

	[Column("contributionPointRequirement")]
	public uint ContributionPointRequirement { get; set; }

	[Column("item2IdTier00")]
	public uint Item2IdTier00 { get; set; }

	[Column("item2IdTier01")]
	public uint Item2IdTier01 { get; set; }

	[Column("item2IdTier02")]
	public uint Item2IdTier02 { get; set; }

	[Column("item2IdTier03")]
	public uint Item2IdTier03 { get; set; }

	[Column("item2IdTier04")]
	public uint Item2IdTier04 { get; set; }

	[Column("contributionPointValueTier00")]
	public uint ContributionPointValueTier00 { get; set; }

	[Column("contributionPointValueTier01")]
	public uint ContributionPointValueTier01 { get; set; }

	[Column("contributionPointValueTier02")]
	public uint ContributionPointValueTier02 { get; set; }

	[Column("contributionPointValueTier03")]
	public uint ContributionPointValueTier03 { get; set; }

	[Column("contributionPointValueTier04")]
	public uint ContributionPointValueTier04 { get; set; }
}
