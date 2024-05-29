using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RewardTrackRewardsRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("rewardTrackId")]
	public uint RewardTrackId { get; set; }

	[Column("rewardPointFlags")]
	public uint RewardPointFlags { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("currencyTypeId")]
	public uint CurrencyTypeId { get; set; }

	[Column("currencyAmount")]
	public uint CurrencyAmount { get; set; }

	[Column("rewardTrackRewardTypeEnum00")]
	public uint RewardTrackRewardTypeEnum00 { get; set; }

	[Column("rewardTrackRewardTypeEnum01")]
	public uint RewardTrackRewardTypeEnum01 { get; set; }

	[Column("rewardTrackRewardTypeEnum02")]
	public uint RewardTrackRewardTypeEnum02 { get; set; }

	[Column("rewardChoiceId00")]
	public uint RewardChoiceId00 { get; set; }

	[Column("rewardChoiceId01")]
	public uint RewardChoiceId01 { get; set; }

	[Column("rewardChoiceId02")]
	public uint RewardChoiceId02 { get; set; }

	[Column("rewardChoiceCount00")]
	public uint RewardChoiceCount00 { get; set; }

	[Column("rewardChoiceCount01")]
	public uint RewardChoiceCount01 { get; set; }

	[Column("rewardChoiceCount02")]
	public uint RewardChoiceCount02 { get; set; }
}
