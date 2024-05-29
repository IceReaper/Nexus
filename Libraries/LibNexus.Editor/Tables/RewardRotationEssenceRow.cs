using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RewardRotationEssenceRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("accountCurrencyTypeId")]
	public uint AccountCurrencyTypeId { get; set; }

	[Column("minPlayerLevel")]
	public uint MinPlayerLevel { get; set; }

	[Column("worldDifficultyFlags")]
	public uint WorldDifficultyFlags { get; set; }
}
