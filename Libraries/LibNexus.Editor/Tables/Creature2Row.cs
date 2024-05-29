using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Creature2Row
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("CreationTypeEnum")]
	public uint CreationTypeEnum { get; set; }

	[Column("description")]
	public string Description { get; set; } = string.Empty;

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("creature2AoiSizeEnum")]
	public uint Creature2AoiSizeEnum { get; set; }

	[Column("unitRaceId")]
	public uint UnitRaceId { get; set; }

	[Column("creature2DifficultyId")]
	public uint Creature2DifficultyId { get; set; }

	[Column("creature2ArcheTypeId")]
	public uint Creature2ArcheTypeId { get; set; }

	[Column("creature2TierId")]
	public uint Creature2TierId { get; set; }

	[Column("creature2ModelInfoId")]
	public uint Creature2ModelInfoId { get; set; }

	[Column("creature2DisplayGroupId")]
	public uint Creature2DisplayGroupId { get; set; }

	[Column("creature2OutfitGroupId")]
	public uint Creature2OutfitGroupId { get; set; }

	[Column("prerequisiteIdVisibility")]
	public uint PrerequisiteIdVisibility { get; set; }

	[Column("modelScale")]
	public float ModelScale { get; set; }

	[Column("spell4IdActivate00")]
	public uint Spell4IdActivate00 { get; set; }

	[Column("spell4IdActivate01")]
	public uint Spell4IdActivate01 { get; set; }

	[Column("spell4IdActivate02")]
	public uint Spell4IdActivate02 { get; set; }

	[Column("spell4IdActivate03")]
	public uint Spell4IdActivate03 { get; set; }

	[Column("prerequisiteIdActivateSpell00")]
	public uint PrerequisiteIdActivateSpell00 { get; set; }

	[Column("prerequisiteIdActivateSpell01")]
	public uint PrerequisiteIdActivateSpell01 { get; set; }

	[Column("prerequisiteIdActivateSpell02")]
	public uint PrerequisiteIdActivateSpell02 { get; set; }

	[Column("prerequisiteIdActivateSpell03")]
	public uint PrerequisiteIdActivateSpell03 { get; set; }

	[Column("activateSpellCastTime")]
	public uint ActivateSpellCastTime { get; set; }

	[Column("activateSpellMinRange")]
	public float ActivateSpellMinRange { get; set; }

	[Column("activateSpellMaxRange")]
	public float ActivateSpellMaxRange { get; set; }

	[Column("localizedTextIdActivateSpellText")]
	public uint LocalizedTextIdActivateSpellText { get; set; }

	[Column("spell4VisualGroupIdActivateSpell")]
	public uint Spell4VisualGroupIdActivateSpell { get; set; }

	[Column("trainerClassIdMask")]
	public uint TrainerClassIdMask { get; set; }

	[Column("tradeSkillIdTrainer")]
	public uint TradeSkillIdTrainer { get; set; }

	[Column("tradeSkillIdStation")]
	public uint TradeSkillIdStation { get; set; }

	[Column("questIdGiven00")]
	public uint QuestIdGiven00 { get; set; }

	[Column("questIdGiven01")]
	public uint QuestIdGiven01 { get; set; }

	[Column("questIdGiven02")]
	public uint QuestIdGiven02 { get; set; }

	[Column("questIdGiven03")]
	public uint QuestIdGiven03 { get; set; }

	[Column("questIdGiven04")]
	public uint QuestIdGiven04 { get; set; }

	[Column("questIdGiven05")]
	public uint QuestIdGiven05 { get; set; }

	[Column("questIdGiven06")]
	public uint QuestIdGiven06 { get; set; }

	[Column("questIdGiven07")]
	public uint QuestIdGiven07 { get; set; }

	[Column("questIdGiven08")]
	public uint QuestIdGiven08 { get; set; }

	[Column("questIdGiven09")]
	public uint QuestIdGiven09 { get; set; }

	[Column("questIdGiven10")]
	public uint QuestIdGiven10 { get; set; }

	[Column("questIdGiven11")]
	public uint QuestIdGiven11 { get; set; }

	[Column("questIdGiven12")]
	public uint QuestIdGiven12 { get; set; }

	[Column("questIdGiven13")]
	public uint QuestIdGiven13 { get; set; }

	[Column("questIdGiven14")]
	public uint QuestIdGiven14 { get; set; }

	[Column("questIdGiven15")]
	public uint QuestIdGiven15 { get; set; }

	[Column("questIdGiven16")]
	public uint QuestIdGiven16 { get; set; }

	[Column("questIdGiven17")]
	public uint QuestIdGiven17 { get; set; }

	[Column("questIdGiven18")]
	public uint QuestIdGiven18 { get; set; }

	[Column("questIdGiven19")]
	public uint QuestIdGiven19 { get; set; }

	[Column("questIdGiven20")]
	public uint QuestIdGiven20 { get; set; }

	[Column("questIdGiven21")]
	public uint QuestIdGiven21 { get; set; }

	[Column("questIdGiven22")]
	public uint QuestIdGiven22 { get; set; }

	[Column("questIdGiven23")]
	public uint QuestIdGiven23 { get; set; }

	[Column("questIdGiven24")]
	public uint QuestIdGiven24 { get; set; }

	[Column("questIdReceive00")]
	public uint QuestIdReceive00 { get; set; }

	[Column("questIdReceive01")]
	public uint QuestIdReceive01 { get; set; }

	[Column("questIdReceive02")]
	public uint QuestIdReceive02 { get; set; }

	[Column("questIdReceive03")]
	public uint QuestIdReceive03 { get; set; }

	[Column("questIdReceive04")]
	public uint QuestIdReceive04 { get; set; }

	[Column("questIdReceive05")]
	public uint QuestIdReceive05 { get; set; }

	[Column("questIdReceive06")]
	public uint QuestIdReceive06 { get; set; }

	[Column("questIdReceive07")]
	public uint QuestIdReceive07 { get; set; }

	[Column("questIdReceive08")]
	public uint QuestIdReceive08 { get; set; }

	[Column("questIdReceive09")]
	public uint QuestIdReceive09 { get; set; }

	[Column("questIdReceive10")]
	public uint QuestIdReceive10 { get; set; }

	[Column("questIdReceive11")]
	public uint QuestIdReceive11 { get; set; }

	[Column("questIdReceive12")]
	public uint QuestIdReceive12 { get; set; }

	[Column("questIdReceive13")]
	public uint QuestIdReceive13 { get; set; }

	[Column("questIdReceive14")]
	public uint QuestIdReceive14 { get; set; }

	[Column("questIdReceive15")]
	public uint QuestIdReceive15 { get; set; }

	[Column("questIdReceive16")]
	public uint QuestIdReceive16 { get; set; }

	[Column("questIdReceive17")]
	public uint QuestIdReceive17 { get; set; }

	[Column("questIdReceive18")]
	public uint QuestIdReceive18 { get; set; }

	[Column("questIdReceive19")]
	public uint QuestIdReceive19 { get; set; }

	[Column("questIdReceive20")]
	public uint QuestIdReceive20 { get; set; }

	[Column("questIdReceive21")]
	public uint QuestIdReceive21 { get; set; }

	[Column("questIdReceive22")]
	public uint QuestIdReceive22 { get; set; }

	[Column("questIdReceive23")]
	public uint QuestIdReceive23 { get; set; }

	[Column("questIdReceive24")]
	public uint QuestIdReceive24 { get; set; }

	[Column("questAnimStateId")]
	public uint QuestAnimStateId { get; set; }

	[Column("prerequisiteIdAnimState")]
	public uint PrerequisiteIdAnimState { get; set; }

	[Column("questAnimObjectiveIndex")]
	public uint QuestAnimObjectiveIndex { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("uiFlags")]
	public uint UiFlags { get; set; }

	[Column("activationFlags")]
	public uint ActivationFlags { get; set; }

	[Column("aimYawConstraint")]
	public float AimYawConstraint { get; set; }

	[Column("aimPitchUpConstraint")]
	public float AimPitchUpConstraint { get; set; }

	[Column("aimPitchDownConstraint")]
	public float AimPitchDownConstraint { get; set; }

	[Column("item2IdMTXKey00")]
	public uint Item2IdMtxKey00 { get; set; }

	[Column("item2IdMTXKey01")]
	public uint Item2IdMtxKey01 { get; set; }

	[Column("creature2FamilyId")]
	public uint Creature2FamilyId { get; set; }

	[Column("creature2TractId")]
	public uint Creature2TractId { get; set; }

	[Column("bindPointId")]
	public uint BindPointId { get; set; }

	[Column("resourceConversionGroupId")]
	public uint ResourceConversionGroupId { get; set; }

	[Column("taxiNodeId")]
	public uint TaxiNodeId { get; set; }

	[Column("pathScientistExperimentationId")]
	public uint PathScientistExperimentationId { get; set; }

	[Column("datacubeId")]
	public uint DatacubeId { get; set; }

	[Column("datacubeVolumeId")]
	public uint DatacubeVolumeId { get; set; }

	[Column("factionId")]
	public uint FactionId { get; set; }

	[Column("minLevel")]
	public uint MinLevel { get; set; }

	[Column("maxLevel")]
	public uint MaxLevel { get; set; }

	[Column("rescanCooldownTypeEnum")]
	public uint RescanCooldownTypeEnum { get; set; }

	[Column("rescanCooldown")]
	public uint RescanCooldown { get; set; }

	[Column("creature2AffiliationId")]
	public uint Creature2AffiliationId { get; set; }

	[Column("itemIdDisplayItemRight")]
	public uint ItemIdDisplayItemRight { get; set; }

	[Column("soundEventIdAggro")]
	public uint SoundEventIdAggro { get; set; }

	[Column("soundEventIdAware")]
	public uint SoundEventIdAware { get; set; }

	[Column("soundImpactDescriptionIdOrigin")]
	public uint SoundImpactDescriptionIdOrigin { get; set; }

	[Column("soundImpactDescriptionIdTarget")]
	public uint SoundImpactDescriptionIdTarget { get; set; }

	[Column("soundSwitchIdModel")]
	public uint SoundSwitchIdModel { get; set; }

	[Column("soundCombatLoopId")]
	public uint SoundCombatLoopId { get; set; }

	[Column("randomTextLineIdGoodbye00")]
	public uint RandomTextLineIdGoodbye00 { get; set; }

	[Column("randomTextLineIdGoodbye01")]
	public uint RandomTextLineIdGoodbye01 { get; set; }

	[Column("randomTextLineIdGoodbye02")]
	public uint RandomTextLineIdGoodbye02 { get; set; }

	[Column("randomTextLineIdGoodbye03")]
	public uint RandomTextLineIdGoodbye03 { get; set; }

	[Column("randomTextLineIdGoodbye04")]
	public uint RandomTextLineIdGoodbye04 { get; set; }

	[Column("randomTextLineIdGoodbye05")]
	public uint RandomTextLineIdGoodbye05 { get; set; }

	[Column("randomTextLineIdGoodbye06")]
	public uint RandomTextLineIdGoodbye06 { get; set; }

	[Column("randomTextLineIdGoodbye07")]
	public uint RandomTextLineIdGoodbye07 { get; set; }

	[Column("randomTextLineIdGoodbye08")]
	public uint RandomTextLineIdGoodbye08 { get; set; }

	[Column("randomTextLineIdGoodbye09")]
	public uint RandomTextLineIdGoodbye09 { get; set; }

	[Column("randomTextLineIdHello00")]
	public uint RandomTextLineIdHello00 { get; set; }

	[Column("randomTextLineIdHello01")]
	public uint RandomTextLineIdHello01 { get; set; }

	[Column("randomTextLineIdHello02")]
	public uint RandomTextLineIdHello02 { get; set; }

	[Column("randomTextLineIdHello03")]
	public uint RandomTextLineIdHello03 { get; set; }

	[Column("randomTextLineIdHello04")]
	public uint RandomTextLineIdHello04 { get; set; }

	[Column("randomTextLineIdHello05")]
	public uint RandomTextLineIdHello05 { get; set; }

	[Column("randomTextLineIdHello06")]
	public uint RandomTextLineIdHello06 { get; set; }

	[Column("randomTextLineIdHello07")]
	public uint RandomTextLineIdHello07 { get; set; }

	[Column("randomTextLineIdHello08")]
	public uint RandomTextLineIdHello08 { get; set; }

	[Column("randomTextLineIdHello09")]
	public uint RandomTextLineIdHello09 { get; set; }

	[Column("randomTextLineIdIntro")]
	public uint RandomTextLineIdIntro { get; set; }

	[Column("localizedTextIdDefaultGreeting")]
	public uint LocalizedTextIdDefaultGreeting { get; set; }

	[Column("randomTextLineIdReturn00")]
	public uint RandomTextLineIdReturn00 { get; set; }

	[Column("randomTextLineIdReturn01")]
	public uint RandomTextLineIdReturn01 { get; set; }

	[Column("randomTextLineIdReturn02")]
	public uint RandomTextLineIdReturn02 { get; set; }

	[Column("randomTextLineIdReturn03")]
	public uint RandomTextLineIdReturn03 { get; set; }

	[Column("randomTextLineIdReturn04")]
	public uint RandomTextLineIdReturn04 { get; set; }

	[Column("randomTextLineIdReturn05")]
	public uint RandomTextLineIdReturn05 { get; set; }

	[Column("randomTextLineIdReturn06")]
	public uint RandomTextLineIdReturn06 { get; set; }

	[Column("randomTextLineIdReturn07")]
	public uint RandomTextLineIdReturn07 { get; set; }

	[Column("randomTextLineIdReturn08")]
	public uint RandomTextLineIdReturn08 { get; set; }

	[Column("randomTextLineIdReturn09")]
	public uint RandomTextLineIdReturn09 { get; set; }

	[Column("localizedTextIdReturnGreeting")]
	public uint LocalizedTextIdReturnGreeting { get; set; }

	[Column("randomTextLineIdCompleted")]
	public uint RandomTextLineIdCompleted { get; set; }

	[Column("localizedTextIdCompletedGreeting")]
	public uint LocalizedTextIdCompletedGreeting { get; set; }

	[Column("unitVoiceTypeId")]
	public uint UnitVoiceTypeId { get; set; }

	[Column("gossipSetId")]
	public uint GossipSetId { get; set; }

	[Column("unitVisualTypeId")]
	public uint UnitVisualTypeId { get; set; }

	[Column("spell4VisualGroupIdAttached")]
	public uint Spell4VisualGroupIdAttached { get; set; }

	[Column("genericStringGroupsIdInteractContext")]
	public uint GenericStringGroupsIdInteractContext { get; set; }

	[Column("creature2ActionSetId")]
	public uint Creature2ActionSetId { get; set; }

	[Column("creature2ActionTextId")]
	public uint Creature2ActionTextId { get; set; }

	[Column("pathMissionIdSoldier")]
	public uint PathMissionIdSoldier { get; set; }

	[Column("instancePortalId")]
	public uint InstancePortalId { get; set; }

	[Column("modelSequenceIdAnimationPriority00")]
	public uint ModelSequenceIdAnimationPriority00 { get; set; }

	[Column("modelSequenceIdAnimationPriority01")]
	public uint ModelSequenceIdAnimationPriority01 { get; set; }

	[Column("modelSequenceIdAnimationPriority02")]
	public uint ModelSequenceIdAnimationPriority02 { get; set; }

	[Column("modelSequenceIdAnimationPriority03")]
	public uint ModelSequenceIdAnimationPriority03 { get; set; }

	[Column("modelSequenceIdAnimationPriority04")]
	public uint ModelSequenceIdAnimationPriority04 { get; set; }

	[Column("prerequisiteIdPriority00")]
	public uint PrerequisiteIdPriority00 { get; set; }

	[Column("prerequisiteIdPriority01")]
	public uint PrerequisiteIdPriority01 { get; set; }

	[Column("prerequisiteIdPriority02")]
	public uint PrerequisiteIdPriority02 { get; set; }

	[Column("prerequisiteIdPriority03")]
	public uint PrerequisiteIdPriority03 { get; set; }

	[Column("prerequisiteIdPriority04")]
	public uint PrerequisiteIdPriority04 { get; set; }

	[Column("donutDrawDistance")]
	public float DonutDrawDistance { get; set; }

	[Column("archiveArticleIdInteractUnlock")]
	public uint ArchiveArticleIdInteractUnlock { get; set; }

	[Column("tradeskillHarvestingInfoId")]
	public uint TradeskillHarvestingInfoId { get; set; }

	[Column("ccStateImmunitiesFlags")]
	public uint CcStateImmunitiesFlags { get; set; }

	[Column("creature2ResistId")]
	public uint Creature2ResistId { get; set; }

	[Column("unitVehicleId")]
	public uint UnitVehicleId { get; set; }

	[Column("creature2DisplayInfoIdPortraitOverride")]
	public uint Creature2DisplayInfoIdPortraitOverride { get; set; }
}
