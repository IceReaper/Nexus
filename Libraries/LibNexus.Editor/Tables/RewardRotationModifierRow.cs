using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RewardRotationModifierRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("rewardPropertyId")]
	public uint RewardPropertyId { get; set; }

	[Column("rewardPropertyData")]
	public uint RewardPropertyData { get; set; }

	[Column("value")]
	public float Value { get; set; }

	[Column("minPlayerLevel")]
	public uint MinPlayerLevel { get; set; }

	[Column("worldDifficultyFlags")]
	public uint WorldDifficultyFlags { get; set; }
}
