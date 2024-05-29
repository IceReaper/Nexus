using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MatchingRandomRewardRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("matchTypeEnum")]
	public uint MatchTypeEnum { get; set; }

	[Column("item2Id")]
	public uint Item2Id { get; set; }

	[Column("itemCount")]
	public uint ItemCount { get; set; }

	[Column("currencyTypeId")]
	public uint CurrencyTypeId { get; set; }

	[Column("currencyValue")]
	public uint CurrencyValue { get; set; }

	[Column("xpEarned")]
	public uint XpEarned { get; set; }

	[Column("item2IdLevelScale")]
	public uint Item2IdLevelScale { get; set; }

	[Column("itemCountLevelScale")]
	public uint ItemCountLevelScale { get; set; }

	[Column("currencyTypeIdLevelScale")]
	public uint CurrencyTypeIdLevelScale { get; set; }

	[Column("currencyValueLevelScale")]
	public uint CurrencyValueLevelScale { get; set; }

	[Column("xpEarnedLevelScale")]
	public uint XpEarnedLevelScale { get; set; }

	[Column("worldDifficultyEnum")]
	public uint WorldDifficultyEnum { get; set; }
}
