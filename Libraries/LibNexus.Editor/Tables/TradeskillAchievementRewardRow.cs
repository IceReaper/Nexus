using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillAchievementRewardRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("achievementId")]
	public uint AchievementId { get; set; }

	[Column("faction2Id")]
	public uint Faction2Id { get; set; }

	[Column("factionIdAmount")]
	public uint FactionIdAmount { get; set; }

	[Column("talentPoints")]
	public uint TalentPoints { get; set; }

	[Column("tradeSkillSchematicId00")]
	public uint TradeSkillSchematicId00 { get; set; }

	[Column("tradeSkillSchematicId01")]
	public uint TradeSkillSchematicId01 { get; set; }

	[Column("tradeSkillSchematicId02")]
	public uint TradeSkillSchematicId02 { get; set; }

	[Column("tradeSkillSchematicId03")]
	public uint TradeSkillSchematicId03 { get; set; }

	[Column("tradeSkillSchematicId04")]
	public uint TradeSkillSchematicId04 { get; set; }

	[Column("tradeSkillSchematicId05")]
	public uint TradeSkillSchematicId05 { get; set; }

	[Column("tradeSkillSchematicId06")]
	public uint TradeSkillSchematicId06 { get; set; }

	[Column("tradeSkillSchematicId07")]
	public uint TradeSkillSchematicId07 { get; set; }
}
