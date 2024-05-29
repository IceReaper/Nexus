using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4ClientMissileRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("missileType")]
	public uint MissileType { get; set; }

	[Column("castStage")]
	public uint CastStage { get; set; }

	[Column("originUnitEnum")]
	public uint OriginUnitEnum { get; set; }

	[Column("targetFlags")]
	public uint TargetFlags { get; set; }

	[Column("modelPath")]
	public string ModelPath { get; set; } = string.Empty;

	[Column("fxPath")]
	public string FxPath { get; set; } = string.Empty;

	[Column("beamPath")]
	public string BeamPath { get; set; } = string.Empty;

	[Column("beamSource")]
	public uint BeamSource { get; set; }

	[Column("beamTarget")]
	public uint BeamTarget { get; set; }

	[Column("itemSlot")]
	public uint ItemSlot { get; set; }

	[Column("costumeSide")]
	public uint CostumeSide { get; set; }

	[Column("modelAttachmentIdCaster")]
	public uint ModelAttachmentIdCaster { get; set; }

	[Column("modelAttachmentIdTarget")]
	public uint ModelAttachmentIdTarget { get; set; }

	[Column("clientDelay")]
	public uint ClientDelay { get; set; }

	[Column("modelEventIdDelayedBy")]
	public uint ModelEventIdDelayedBy { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("duration")]
	public uint Duration { get; set; }

	[Column("frequency")]
	public uint Frequency { get; set; }

	[Column("speedMps")]
	public uint SpeedMps { get; set; }

	[Column("accMpss")]
	public float AccMpss { get; set; }

	[Column("revolverNestedMissileInitDelay")]
	public uint RevolverNestedMissileInitDelay { get; set; }

	[Column("revolverNestedMissileSubDelay")]
	public uint RevolverNestedMissileSubDelay { get; set; }

	[Column("spell4ClientMissileIdNested")]
	public uint Spell4ClientMissileIdNested { get; set; }

	[Column("revolverMissileImpactAssetPath")]
	public string RevolverMissileImpactAssetPath { get; set; } = string.Empty;

	[Column("missileRevolverTrackId")]
	public uint MissileRevolverTrackId { get; set; }

	[Column("birthAnchorPath")]
	public string BirthAnchorPath { get; set; } = string.Empty;

	[Column("deathAnchorPath")]
	public string DeathAnchorPath { get; set; } = string.Empty;

	[Column("trajAnchorPath")]
	public string TrajAnchorPath { get; set; } = string.Empty;

	[Column("birthDuration")]
	public float BirthDuration { get; set; }

	[Column("birthAnchorAngleMin")]
	public float BirthAnchorAngleMin { get; set; }

	[Column("birthAnchorAngleMax")]
	public float BirthAnchorAngleMax { get; set; }

	[Column("deathAnchorAngleMin")]
	public float DeathAnchorAngleMin { get; set; }

	[Column("deathAnchorAngleMax")]
	public float DeathAnchorAngleMax { get; set; }

	[Column("deathAnchorSpace")]
	public uint DeathAnchorSpace { get; set; }

	[Column("itemSlotIdObj")]
	public uint ItemSlotIdObj { get; set; }

	[Column("objCostumeSide")]
	public uint ObjCostumeSide { get; set; }

	[Column("trajPoseFullBlendDistance")]
	public float TrajPoseFullBlendDistance { get; set; }

	[Column("trajAnchorPlaySpeed")]
	public float TrajAnchorPlaySpeed { get; set; }

	[Column("parabolaHeightScale")]
	public float ParabolaHeightScale { get; set; }

	[Column("rotateX")]
	public float RotateX { get; set; }

	[Column("rotateY")]
	public float RotateY { get; set; }

	[Column("rotateZ")]
	public float RotateZ { get; set; }

	[Column("scale")]
	public float Scale { get; set; }

	[Column("endScale")]
	public float EndScale { get; set; }

	[Column("phaseFlags")]
	public uint PhaseFlags { get; set; }

	[Column("telegraphDamageIdAttach")]
	public uint TelegraphDamageIdAttach { get; set; }

	[Column("soundEventIdBirth")]
	public uint SoundEventIdBirth { get; set; }

	[Column("soundEventIdLoopStart")]
	public uint SoundEventIdLoopStart { get; set; }

	[Column("soundEventIdLoopStop")]
	public uint SoundEventIdLoopStop { get; set; }

	[Column("soundEventIdDeath")]
	public uint SoundEventIdDeath { get; set; }

	[Column("beamDiffuseColor")]
	public uint BeamDiffuseColor { get; set; }

	[Column("missileDiffuseColor")]
	public uint MissileDiffuseColor { get; set; }
}
