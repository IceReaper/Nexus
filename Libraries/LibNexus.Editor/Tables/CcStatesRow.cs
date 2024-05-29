using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CcStatesRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("defaultBreakProbability")]
	public float DefaultBreakProbability { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("spellIcon")]
	public string SpellIcon { get; set; } = string.Empty;

	[Column("visualEffectId00")]
	public uint VisualEffectId00 { get; set; }

	[Column("visualEffectId01")]
	public uint VisualEffectId01 { get; set; }

	[Column("visualEffectId02")]
	public uint VisualEffectId02 { get; set; }

	[Column("ccStateDiminishingReturnsId")]
	public uint CcStateDiminishingReturnsId { get; set; }
}
