using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MatchTypeRewardRotationContentRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("matchTypeEnum")]
	public uint MatchTypeEnum { get; set; }

	[Column("rewardRotationContentIdRandomNormal")]
	public uint RewardRotationContentIdRandomNormal { get; set; }

	[Column("rewardRotationContentIdRandomVeteran")]
	public uint RewardRotationContentIdRandomVeteran { get; set; }
}
