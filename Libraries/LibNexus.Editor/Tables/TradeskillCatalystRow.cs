using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillCatalystRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("tradeSkillId")]
	public uint TradeSkillId { get; set; }

	[Column("tier")]
	public uint Tier { get; set; }

	[Column("tradeskillCatalystEnum00")]
	public uint TradeskillCatalystEnum00 { get; set; }

	[Column("tradeskillCatalystEnum01")]
	public uint TradeskillCatalystEnum01 { get; set; }

	[Column("tradeskillCatalystEnum02")]
	public uint TradeskillCatalystEnum02 { get; set; }

	[Column("tradeskillCatalystEnum03")]
	public uint TradeskillCatalystEnum03 { get; set; }

	[Column("tradeskillCatalystEnum04")]
	public uint TradeskillCatalystEnum04 { get; set; }

	[Column("value00")]
	public float Value00 { get; set; }

	[Column("value01")]
	public float Value01 { get; set; }

	[Column("value02")]
	public float Value02 { get; set; }

	[Column("value03")]
	public float Value03 { get; set; }

	[Column("value04")]
	public float Value04 { get; set; }
}
