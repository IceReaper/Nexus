using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4EffectsRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("spellId")]
	public uint SpellId { get; set; }

	[Column("targetFlags")]
	public uint TargetFlags { get; set; }

	[Column("effectType")]
	public uint EffectType { get; set; }

	[Column("damageType")]
	public uint DamageType { get; set; }

	[Column("delayTime")]
	public uint DelayTime { get; set; }

	[Column("tickTime")]
	public uint TickTime { get; set; }

	[Column("durationTime")]
	public uint DurationTime { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("dataBits00")]
	public uint DataBits00 { get; set; }

	[Column("dataBits01")]
	public uint DataBits01 { get; set; }

	[Column("dataBits02")]
	public uint DataBits02 { get; set; }

	[Column("dataBits03")]
	public uint DataBits03 { get; set; }

	[Column("dataBits04")]
	public uint DataBits04 { get; set; }

	[Column("dataBits05")]
	public uint DataBits05 { get; set; }

	[Column("dataBits06")]
	public uint DataBits06 { get; set; }

	[Column("dataBits07")]
	public uint DataBits07 { get; set; }

	[Column("dataBits08")]
	public uint DataBits08 { get; set; }

	[Column("dataBits09")]
	public uint DataBits09 { get; set; }

	[Column("innateCostPerTickType0")]
	public uint InnateCostPerTickType0 { get; set; }

	[Column("innateCostPerTickType1")]
	public uint InnateCostPerTickType1 { get; set; }

	[Column("innateCostPerTick0")]
	public uint InnateCostPerTick0 { get; set; }

	[Column("innateCostPerTick1")]
	public uint InnateCostPerTick1 { get; set; }

	[Column("emmComparison")]
	public uint EmmComparison { get; set; }

	[Column("emmValue")]
	public uint EmmValue { get; set; }

	[Column("threatMultiplier")]
	public float ThreatMultiplier { get; set; }

	[Column("spell4EffectGroupListId")]
	public uint Spell4EffectGroupListId { get; set; }

	[Column("prerequisiteIdCasterApply")]
	public uint PrerequisiteIdCasterApply { get; set; }

	[Column("prerequisiteIdTargetApply")]
	public uint PrerequisiteIdTargetApply { get; set; }

	[Column("prerequisiteIdCasterPersistence")]
	public uint PrerequisiteIdCasterPersistence { get; set; }

	[Column("prerequisiteIdTargetPersistence")]
	public uint PrerequisiteIdTargetPersistence { get; set; }

	[Column("prerequisiteIdTargetSuspend")]
	public uint PrerequisiteIdTargetSuspend { get; set; }

	[Column("parameterType00")]
	public uint ParameterType00 { get; set; }

	[Column("parameterType01")]
	public uint ParameterType01 { get; set; }

	[Column("parameterType02")]
	public uint ParameterType02 { get; set; }

	[Column("parameterType03")]
	public uint ParameterType03 { get; set; }

	[Column("parameterValue00")]
	public float ParameterValue00 { get; set; }

	[Column("parameterValue01")]
	public float ParameterValue01 { get; set; }

	[Column("parameterValue02")]
	public float ParameterValue02 { get; set; }

	[Column("parameterValue03")]
	public float ParameterValue03 { get; set; }

	[Column("phaseFlags")]
	public uint PhaseFlags { get; set; }

	[Column("orderIndex")]
	public uint OrderIndex { get; set; }
}
