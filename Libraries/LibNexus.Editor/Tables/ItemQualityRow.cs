using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemQualityRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("salvageCritChance")]
	public float SalvageCritChance { get; set; }

	[Column("turninMultiplier")]
	public float TurninMultiplier { get; set; }

	[Column("runeCostMultiplier")]
	public float RuneCostMultiplier { get; set; }

	[Column("dyeCostMultiplier")]
	public float DyeCostMultiplier { get; set; }

	[Column("visualEffectIdLoot")]
	public uint VisualEffectIdLoot { get; set; }

	[Column("iconColorR")]
	public float IconColorR { get; set; }

	[Column("iconColorG")]
	public float IconColorG { get; set; }

	[Column("iconColorB")]
	public float IconColorB { get; set; }

	[Column("defaultRunes")]
	public uint DefaultRunes { get; set; }

	[Column("maxRunes")]
	public uint MaxRunes { get; set; }

	[Column("assetPathDieModel")]
	public string AssetPathDieModel { get; set; } = string.Empty;

	[Column("soundEventIdFortuneCardFanfare")]
	public uint SoundEventIdFortuneCardFanfare { get; set; }
}
