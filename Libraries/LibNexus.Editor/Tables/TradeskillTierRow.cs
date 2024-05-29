using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillTierRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("tradeSkillId")]
	public uint TradeSkillId { get; set; }

	[Column("tier")]
	public uint Tier { get; set; }

	[Column("requiredXp")]
	public uint RequiredXp { get; set; }

	[Column("learnXp")]
	public uint LearnXp { get; set; }

	[Column("craftXp")]
	public uint CraftXp { get; set; }

	[Column("firstCraftXp")]
	public uint FirstCraftXp { get; set; }

	[Column("questXp")]
	public uint QuestXp { get; set; }

	[Column("failXp")]
	public uint FailXp { get; set; }

	[Column("itemLevelMin")]
	public uint ItemLevelMin { get; set; }

	[Column("maxAdditives")]
	public uint MaxAdditives { get; set; }

	[Column("relearnCost")]
	public ulong RelearnCost { get; set; }

	[Column("achievementCategoryId")]
	public uint AchievementCategoryId { get; set; }
}
