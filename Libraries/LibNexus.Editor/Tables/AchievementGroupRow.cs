using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class AchievementGroupRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("tradeSkillId")]
	public uint TradeSkillId { get; set; }
}
