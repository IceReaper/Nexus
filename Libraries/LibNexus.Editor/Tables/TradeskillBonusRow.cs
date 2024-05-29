using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillBonusRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("tradeSkillTierId")]
	public uint TradeSkillTierId { get; set; }

	[Column("achievementId")]
	public uint AchievementId { get; set; }

	[Column("iconPath")]
	public string IconPath { get; set; } = string.Empty;

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdTooltip")]
	public uint LocalizedTextIdTooltip { get; set; }

	[Column("tradeskillBonusEnum00")]
	public uint TradeskillBonusEnum00 { get; set; }

	[Column("tradeskillBonusEnum01")]
	public uint TradeskillBonusEnum01 { get; set; }

	[Column("tradeskillBonusEnum02")]
	public uint TradeskillBonusEnum02 { get; set; }

	[Column("objectIdPrimary00")]
	public uint ObjectIdPrimary00 { get; set; }

	[Column("objectIdPrimary01")]
	public uint ObjectIdPrimary01 { get; set; }

	[Column("objectIdPrimary02")]
	public uint ObjectIdPrimary02 { get; set; }

	[Column("objectIdSecondary00")]
	public uint ObjectIdSecondary00 { get; set; }

	[Column("objectIdSecondary01")]
	public uint ObjectIdSecondary01 { get; set; }

	[Column("objectIdSecondary02")]
	public uint ObjectIdSecondary02 { get; set; }

	[Column("objectIdTertiary00")]
	public uint ObjectIdTertiary00 { get; set; }

	[Column("objectIdTertiary01")]
	public uint ObjectIdTertiary01 { get; set; }

	[Column("objectIdTertiary02")]
	public uint ObjectIdTertiary02 { get; set; }

	[Column("value00")]
	public float Value00 { get; set; }

	[Column("value01")]
	public float Value01 { get; set; }

	[Column("value02")]
	public float Value02 { get; set; }

	[Column("valueInt00")]
	public uint ValueInt00 { get; set; }

	[Column("valueInt01")]
	public uint ValueInt01 { get; set; }

	[Column("valueInt02")]
	public uint ValueInt02 { get; set; }
}
