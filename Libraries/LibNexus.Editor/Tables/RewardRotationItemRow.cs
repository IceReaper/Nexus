using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RewardRotationItemRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("rewardItemTypeEnum")]
	public uint RewardItemTypeEnum { get; set; }

	[Column("rewardItemObject")]
	public uint RewardItemObject { get; set; }

	[Column("count")]
	public uint Count { get; set; }

	[Column("iconPath")]
	public string IconPath { get; set; } = string.Empty;

	[Column("minPlayerLevel")]
	public uint MinPlayerLevel { get; set; }

	[Column("worldDifficultyFlags")]
	public uint WorldDifficultyFlags { get; set; }
}
