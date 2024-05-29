using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4ThresholdsRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("spell4IdParent")]
	public uint Spell4IdParent { get; set; }

	[Column("spell4IdToCast")]
	public uint Spell4IdToCast { get; set; }

	[Column("orderIndex")]
	public uint OrderIndex { get; set; }

	[Column("thresholdDuration")]
	public uint ThresholdDuration { get; set; }

	[Column("vitalEnumCostType00")]
	public uint VitalEnumCostType00 { get; set; }

	[Column("vitalEnumCostType01")]
	public uint VitalEnumCostType01 { get; set; }

	[Column("vitalCostValue00")]
	public uint VitalCostValue00 { get; set; }

	[Column("vitalCostValue01")]
	public uint VitalCostValue01 { get; set; }

	[Column("localizedTextIdTooltip")]
	public uint LocalizedTextIdTooltip { get; set; }

	[Column("iconReplacement")]
	public string IconReplacement { get; set; } = string.Empty;

	[Column("visualEffectId")]
	public uint VisualEffectId { get; set; }
}
