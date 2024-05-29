using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Quest2DifficultyRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("xpMultiplier")]
	public float XpMultiplier { get; set; }

	[Column("cashRewardMultiplier")]
	public float CashRewardMultiplier { get; set; }

	[Column("repRewardMultiplier")]
	public float RepRewardMultiplier { get; set; }
}
