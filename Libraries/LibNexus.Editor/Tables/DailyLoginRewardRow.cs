using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class DailyLoginRewardRow
{
	[Column("id")]
	public uint Id { get; set; }

	[Column("loginDay")]
	public uint LoginDay { get; set; }

	[Column("dailyLoginRewardTypeEnum")]
	public uint DailyLoginRewardTypeEnum { get; set; }

	[Column("rewardObjectValue")]
	public uint RewardObjectValue { get; set; }

	[Column("dailyLoginRewardTierEnum")]
	public uint DailyLoginRewardTierEnum { get; set; }
}
