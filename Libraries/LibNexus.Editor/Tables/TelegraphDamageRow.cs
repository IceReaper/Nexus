using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TelegraphDamageRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("telegraphSubtypeEnum")]
	public uint TelegraphSubtypeEnum { get; set; }

	[Column("damageShapeEnum")]
	public uint DamageShapeEnum { get; set; }

	[Column("param00")]
	public float Param00 { get; set; }

	[Column("param01")]
	public float Param01 { get; set; }

	[Column("param02")]
	public float Param02 { get; set; }

	[Column("param03")]
	public float Param03 { get; set; }

	[Column("param04")]
	public float Param04 { get; set; }

	[Column("param05")]
	public float Param05 { get; set; }

	[Column("telegraphTimeStartMs")]
	public uint TelegraphTimeStartMs { get; set; }

	[Column("telegraphTimeEndMs")]
	public uint TelegraphTimeEndMs { get; set; }

	[Column("telegraphTimeRampInMs")]
	public uint TelegraphTimeRampInMs { get; set; }

	[Column("telegraphTimeRampOutMs")]
	public uint TelegraphTimeRampOutMs { get; set; }

	[Column("xPositionOffset")]
	public float XPositionOffset { get; set; }

	[Column("yPositionOffset")]
	public float YPositionOffset { get; set; }

	[Column("zPositionOffset")]
	public float ZPositionOffset { get; set; }

	[Column("rotationDegrees")]
	public float RotationDegrees { get; set; }

	[Column("telegraphDamageFlags")]
	public uint TelegraphDamageFlags { get; set; }

	[Column("targetTypeFlags")]
	public uint TargetTypeFlags { get; set; }

	[Column("phaseFlags")]
	public uint PhaseFlags { get; set; }

	[Column("prerequisiteIdCaster")]
	public uint PrerequisiteIdCaster { get; set; }

	[Column("spellThresholdRestrictionFlags")]
	public uint SpellThresholdRestrictionFlags { get; set; }

	[Column("displayFlags")]
	public uint DisplayFlags { get; set; }

	[Column("opacityModifier")]
	public uint OpacityModifier { get; set; }

	[Column("displayGroup")]
	public uint DisplayGroup { get; set; }
}
