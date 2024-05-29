using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CombatRewardRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("combatRewardTypeEnum")]
	public uint CombatRewardTypeEnum { get; set; }

	[Column("localizedTextIdCombatFloater")]
	public uint LocalizedTextIdCombatFloater { get; set; }

	[Column("localizedTextIdCombatLogMessage")]
	public uint LocalizedTextIdCombatLogMessage { get; set; }

	[Column("visualEffectIdVisual00")]
	public uint VisualEffectIdVisual00 { get; set; }

	[Column("visualEffectIdVisual01")]
	public uint VisualEffectIdVisual01 { get; set; }
}
