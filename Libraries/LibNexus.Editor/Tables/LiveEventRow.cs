using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class LiveEventRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("liveEventTypeEnum")]
	public uint LiveEventTypeEnum { get; set; }

	[Column("maxValue")]
	public uint MaxValue { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("liveEventCategoryEnum")]
	public uint LiveEventCategoryEnum { get; set; }

	[Column("liveEventIdParent")]
	public uint LiveEventIdParent { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdSummary")]
	public uint LocalizedTextIdSummary { get; set; }

	[Column("iconPath")]
	public string IconPath { get; set; } = string.Empty;

	[Column("iconPathButton")]
	public string IconPathButton { get; set; } = string.Empty;

	[Column("spritePathTitle")]
	public string SpritePathTitle { get; set; } = string.Empty;

	[Column("spritePathBackground")]
	public string SpritePathBackground { get; set; } = string.Empty;

	[Column("currencyTypeIdEarned")]
	public uint CurrencyTypeIdEarned { get; set; }

	[Column("localizedTextIdCurrencyEarnedTooltip")]
	public uint LocalizedTextIdCurrencyEarnedTooltip { get; set; }

	[Column("worldLocation2IdExile")]
	public uint WorldLocation2IdExile { get; set; }

	[Column("worldLocation2IdDominion")]
	public uint WorldLocation2IdDominion { get; set; }
}
