using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillHarvestingInfoRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("tradeSkillTierId")]
	public uint TradeSkillTierId { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[Column("miniMapMarkerId")]
	public uint MiniMapMarkerId { get; set; }
}
