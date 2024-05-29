using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4Row
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("description")]
	public string Description { get; set; } = string.Empty;

	[Column("spell4BaseIdBaseSpell")]
	public uint Spell4BaseIdBaseSpell { get; set; }

	[Column("tierIndex")]
	public uint TierIndex { get; set; }

	[Column("ravelInstanceId")]
	public uint RavelInstanceId { get; set; }

	[Column("castTime")]
	public uint CastTime { get; set; }

	[Column("spellDuration")]
	public uint SpellDuration { get; set; }

	[Column("spellCoolDown")]
	public uint SpellCoolDown { get; set; }

	[Column("targetMinRange")]
	public float TargetMinRange { get; set; }

	[Column("targetMaxRange")]
	public float TargetMaxRange { get; set; }

	[Column("targetVerticalRange")]
	public float TargetVerticalRange { get; set; }

	[Column("casterInnateRequirement0")]
	public uint CasterInnateRequirement0 { get; set; }

	[Column("casterInnateRequirement1")]
	public uint CasterInnateRequirement1 { get; set; }

	[Column("casterInnateRequirementValue0")]
	public uint CasterInnateRequirementValue0 { get; set; }

	[Column("casterInnateRequirementValue1")]
	public uint CasterInnateRequirementValue1 { get; set; }

	[Column("casterInnateRequirementEval0")]
	public uint CasterInnateRequirementEval0 { get; set; }

	[Column("casterInnateRequirementEval1")]
	public uint CasterInnateRequirementEval1 { get; set; }

	[Column("targetBeginInnateRequirement")]
	public uint TargetBeginInnateRequirement { get; set; }

	[Column("targetBeginInnateRequirementValue")]
	public uint TargetBeginInnateRequirementValue { get; set; }

	[Column("targetBeginInnateRequirementEval")]
	public uint TargetBeginInnateRequirementEval { get; set; }

	[Column("innateCostType0")]
	public uint InnateCostType0 { get; set; }

	[Column("innateCostType1")]
	public uint InnateCostType1 { get; set; }

	[Column("innateCost0")]
	public uint InnateCost0 { get; set; }

	[Column("innateCost1")]
	public uint InnateCost1 { get; set; }

	[Column("innateCostEMMId0")]
	public uint InnateCostEmmId0 { get; set; }

	[Column("innateCostEMMId1")]
	public uint InnateCostEmmId1 { get; set; }

	[Column("channelInitialDelay")]
	public uint ChannelInitialDelay { get; set; }

	[Column("channelMaxTime")]
	public uint ChannelMaxTime { get; set; }

	[Column("channelPulseTime")]
	public uint ChannelPulseTime { get; set; }

	[Column("localizedTextIdActionBarTooltip")]
	public uint LocalizedTextIdActionBarTooltip { get; set; }

	[Column("stackPriority")]
	public uint StackPriority { get; set; }

	[Column("spell4VisualGroupId")]
	public uint Spell4VisualGroupId { get; set; }

	[Column("spell4IdCastEvent00")]
	public uint Spell4IdCastEvent00 { get; set; }

	[Column("spell4IdCastEvent01")]
	public uint Spell4IdCastEvent01 { get; set; }

	[Column("spell4IdCastEvent02")]
	public uint Spell4IdCastEvent02 { get; set; }

	[Column("spell4IdCastEvent03")]
	public uint Spell4IdCastEvent03 { get; set; }

	[Column("spell4ReagentId00")]
	public uint Spell4ReagentId00 { get; set; }

	[Column("spell4ReagentId01")]
	public uint Spell4ReagentId01 { get; set; }

	[Column("spell4ReagentId02")]
	public uint Spell4ReagentId02 { get; set; }

	[Column("spell4RunnerId00")]
	public uint Spell4RunnerId00 { get; set; }

	[Column("spell4RunnerId01")]
	public uint Spell4RunnerId01 { get; set; }

	[Column("runnerTargetTypeEnum00")]
	public uint RunnerTargetTypeEnum00 { get; set; }

	[Column("runnerTargetTypeEnum01")]
	public uint RunnerTargetTypeEnum01 { get; set; }

	[Column("prerequisiteIdRunner00")]
	public uint PrerequisiteIdRunner00 { get; set; }

	[Column("prerequisiteIdRunner01")]
	public uint PrerequisiteIdRunner01 { get; set; }

	[Column("abilityChargeCount")]
	public uint AbilityChargeCount { get; set; }

	[Column("abilityRechargeTime")]
	public uint AbilityRechargeTime { get; set; }

	[Column("abilityRechargeCount")]
	public uint AbilityRechargeCount { get; set; }

	[Column("thresholdTime")]
	public uint ThresholdTime { get; set; }

	[Column("abilityPointCost")]
	public uint AbilityPointCost { get; set; }

	[Column("trainingCost")]
	public uint TrainingCost { get; set; }

	[Column("spellChannelFlags")]
	public uint SpellChannelFlags { get; set; }

	[Column("ignoreFollowTimeMs")]
	public uint IgnoreFollowTimeMs { get; set; }

	[Column("spell4IdMechanicAlternateSpell")]
	public uint Spell4IdMechanicAlternateSpell { get; set; }

	[Column("spell4IdPetSwitch")]
	public uint Spell4IdPetSwitch { get; set; }

	[Column("spell4TagId00")]
	public uint Spell4TagId00 { get; set; }

	[Column("spell4TagId01")]
	public uint Spell4TagId01 { get; set; }

	[Column("spell4TagId02")]
	public uint Spell4TagId02 { get; set; }

	[Column("spell4TagId03")]
	public uint Spell4TagId03 { get; set; }

	[Column("spell4TagId04")]
	public uint Spell4TagId04 { get; set; }

	[Column("localizedTextIdCasterIconSpellText")]
	public uint LocalizedTextIdCasterIconSpellText { get; set; }

	[Column("localizedTextIdPrimaryTargetIconSpellText")]
	public uint LocalizedTextIdPrimaryTargetIconSpellText { get; set; }

	[Column("localizedTextIdSecondaryTargetIconSpellText")]
	public uint LocalizedTextIdSecondaryTargetIconSpellText { get; set; }

	[Column("localizedTextIdLASTier")]
	public uint LocalizedTextIdLasTier { get; set; }

	[Column("localizedTextIdTooltipCastInfo")]
	public uint LocalizedTextIdTooltipCastInfo { get; set; }

	[Column("localizedTextIdTooltipCostInfo")]
	public uint LocalizedTextIdTooltipCostInfo { get; set; }

	[Column("tooltipCastTime")]
	public uint TooltipCastTime { get; set; }

	[Column("spell4AoeTargetConstraintsId")]
	public uint Spell4AoeTargetConstraintsId { get; set; }

	[Column("spell4ConditionsIdCaster")]
	public uint Spell4ConditionsIdCaster { get; set; }

	[Column("spell4ConditionsIdTarget")]
	public uint Spell4ConditionsIdTarget { get; set; }

	[Column("spell4CCConditionsIdCaster")]
	public uint Spell4CcConditionsIdCaster { get; set; }

	[Column("spell4CCConditionsIdTarget")]
	public uint Spell4CcConditionsIdTarget { get; set; }

	[Column("spellCoolDownIdGlobal")]
	public uint SpellCoolDownIdGlobal { get; set; }

	[Column("spellCoolDownId00")]
	public uint SpellCoolDownId00 { get; set; }

	[Column("spellCoolDownId01")]
	public uint SpellCoolDownId01 { get; set; }

	[Column("spellCoolDownId02")]
	public uint SpellCoolDownId02 { get; set; }

	[Column("spell4GroupListId")]
	public uint Spell4GroupListId { get; set; }

	[Column("missileSpeed")]
	public uint MissileSpeed { get; set; }

	[Column("minMissileSpeed")]
	public uint MinMissileSpeed { get; set; }

	[Column("spell4ClientMissileId00")]
	public uint Spell4ClientMissileId00 { get; set; }

	[Column("spell4ClientMissileId01")]
	public uint Spell4ClientMissileId01 { get; set; }

	[Column("spell4ClientMissileId02")]
	public uint Spell4ClientMissileId02 { get; set; }

	[Column("spell4ClientMissileId03")]
	public uint Spell4ClientMissileId03 { get; set; }

	[Column("spell4ClientMissileId04")]
	public uint Spell4ClientMissileId04 { get; set; }

	[Column("spell4ClientMissileId05")]
	public uint Spell4ClientMissileId05 { get; set; }

	[Column("globalCooldownEnum")]
	public uint GlobalCooldownEnum { get; set; }

	[Column("propertyFlags")]
	public uint PropertyFlags { get; set; }

	[Column("uiFlags")]
	public uint UiFlags { get; set; }

	[Column("spell4StackGroupId")]
	public uint Spell4StackGroupId { get; set; }

	[Column("prerequisiteIdCasterCast")]
	public uint PrerequisiteIdCasterCast { get; set; }

	[Column("prerequisiteIdTargetCast")]
	public uint PrerequisiteIdTargetCast { get; set; }

	[Column("prerequisiteIdCasterPersistence")]
	public uint PrerequisiteIdCasterPersistence { get; set; }

	[Column("prerequisiteIdTargetPersistence")]
	public uint PrerequisiteIdTargetPersistence { get; set; }

	[Column("castEventConditionEnum00")]
	public uint CastEventConditionEnum00 { get; set; }

	[Column("castEventConditionEnum01")]
	public uint CastEventConditionEnum01 { get; set; }

	[Column("castEventConditionEnum02")]
	public uint CastEventConditionEnum02 { get; set; }

	[Column("castEventConditionEnum03")]
	public uint CastEventConditionEnum03 { get; set; }

	[Column("castEventTargetFlags00")]
	public uint CastEventTargetFlags00 { get; set; }

	[Column("castEventTargetFlags01")]
	public uint CastEventTargetFlags01 { get; set; }

	[Column("castEventTargetFlags02")]
	public uint CastEventTargetFlags02 { get; set; }

	[Column("castEventTargetFlags03")]
	public uint CastEventTargetFlags03 { get; set; }

	[Column("spellCastStealthChange")]
	public uint SpellCastStealthChange { get; set; }

	[Column("prerequisiteIdAoeTarget")]
	public uint PrerequisiteIdAoeTarget { get; set; }

	[Column("prerequisiteIdAoePreferredTarget")]
	public uint PrerequisiteIdAoePreferredTarget { get; set; }
}
