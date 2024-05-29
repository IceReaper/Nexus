using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillAdditiveRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("tradeSkillId")]
	public uint TradeSkillId { get; set; }

	[Column("tier")]
	public uint Tier { get; set; }

	[Column("vectorX")]
	public float VectorX { get; set; }

	[Column("vectorY")]
	public float VectorY { get; set; }

	[Column("radius")]
	public float Radius { get; set; }
}
