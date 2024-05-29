using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillTalentTierRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("tradeSkillId")]
	public uint TradeSkillId { get; set; }

	[Column("pointsToUnlock")]
	public uint PointsToUnlock { get; set; }

	[Column("respecCost")]
	public uint RespecCost { get; set; }

	[Column("tradeSkillBonusId00")]
	public uint TradeSkillBonusId00 { get; set; }

	[Column("tradeSkillBonusId01")]
	public uint TradeSkillBonusId01 { get; set; }

	[Column("tradeSkillBonusId02")]
	public uint TradeSkillBonusId02 { get; set; }

	[Column("tradeSkillBonusId03")]
	public uint TradeSkillBonusId03 { get; set; }

	[Column("tradeSkillBonusId04")]
	public uint TradeSkillBonusId04 { get; set; }
}
