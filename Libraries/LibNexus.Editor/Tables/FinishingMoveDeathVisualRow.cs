using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class FinishingMoveDeathVisualRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("priority")]
	public uint Priority { get; set; }

	[Column("damageTypeFlags")]
	public uint DamageTypeFlags { get; set; }

	[Column("creature2MinSize")]
	public uint Creature2MinSize { get; set; }

	[Column("creature2MaxSize")]
	public uint Creature2MaxSize { get; set; }

	[Column("creatureMaterialEnum")]
	public uint CreatureMaterialEnum { get; set; }

	[Column("movementStateFlags")]
	public uint MovementStateFlags { get; set; }

	[Column("deathModelAsset")]
	public string DeathModelAsset { get; set; } = string.Empty;

	[Column("modelSequenceIdDeath")]
	public uint ModelSequenceIdDeath { get; set; }

	[Column("visualEffectIdDeath00")]
	public uint VisualEffectIdDeath00 { get; set; }

	[Column("visualEffectIdDeath01")]
	public uint VisualEffectIdDeath01 { get; set; }

	[Column("visualEffectIdDeath02")]
	public uint VisualEffectIdDeath02 { get; set; }
}
