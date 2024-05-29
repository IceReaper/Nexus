using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ClassRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("enumName")]
	public string EnumName { get; set; } = string.Empty;

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("localizedTextIdNameFemale")]
	public uint LocalizedTextIdNameFemale { get; set; }

	[Column("mechanic")]
	public uint Mechanic { get; set; }

	[Column("spell4IdInnateAbilityActive00")]
	public uint Spell4IdInnateAbilityActive00 { get; set; }

	[Column("spell4IdInnateAbilityActive01")]
	public uint Spell4IdInnateAbilityActive01 { get; set; }

	[Column("spell4IdInnateAbilityActive02")]
	public uint Spell4IdInnateAbilityActive02 { get; set; }

	[Column("spell4IdInnateAbilityPassive00")]
	public uint Spell4IdInnateAbilityPassive00 { get; set; }

	[Column("spell4IdInnateAbilityPassive01")]
	public uint Spell4IdInnateAbilityPassive01 { get; set; }

	[Column("spell4IdInnateAbilityPassive02")]
	public uint Spell4IdInnateAbilityPassive02 { get; set; }

	[Column("prerequisiteIdInnateAbility00")]
	public uint PrerequisiteIdInnateAbility00 { get; set; }

	[Column("prerequisiteIdInnateAbility01")]
	public uint PrerequisiteIdInnateAbility01 { get; set; }

	[Column("prerequisiteIdInnateAbility02")]
	public uint PrerequisiteIdInnateAbility02 { get; set; }

	[Column("startingItemProficiencies")]
	public uint StartingItemProficiencies { get; set; }

	[Column("spell4IdAttackPrimary00")]
	public uint Spell4IdAttackPrimary00 { get; set; }

	[Column("spell4IdAttackPrimary01")]
	public uint Spell4IdAttackPrimary01 { get; set; }

	[Column("spell4IdAttackUnarmed00")]
	public uint Spell4IdAttackUnarmed00 { get; set; }

	[Column("spell4IdAttackUnarmed01")]
	public uint Spell4IdAttackUnarmed01 { get; set; }

	[Column("spell4IdResAbility")]
	public uint Spell4IdResAbility { get; set; }

	[Column("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[Column("spell4GroupId")]
	public uint Spell4GroupId { get; set; }

	[Column("classIdForClassApModifier")]
	public uint ClassIdForClassApModifier { get; set; }

	[Column("vitalEnumResource00")]
	public uint VitalEnumResource00 { get; set; }

	[Column("vitalEnumResource01")]
	public uint VitalEnumResource01 { get; set; }

	[Column("vitalEnumResource02")]
	public uint VitalEnumResource02 { get; set; }

	[Column("vitalEnumResource03")]
	public uint VitalEnumResource03 { get; set; }

	[Column("vitalEnumResource04")]
	public uint VitalEnumResource04 { get; set; }

	[Column("vitalEnumResource05")]
	public uint VitalEnumResource05 { get; set; }

	[Column("vitalEnumResource06")]
	public uint VitalEnumResource06 { get; set; }

	[Column("vitalEnumResource07")]
	public uint VitalEnumResource07 { get; set; }

	[Column("localizedTextIdResourceAlert00")]
	public uint LocalizedTextIdResourceAlert00 { get; set; }

	[Column("localizedTextIdResourceAlert01")]
	public uint LocalizedTextIdResourceAlert01 { get; set; }

	[Column("localizedTextIdResourceAlert02")]
	public uint LocalizedTextIdResourceAlert02 { get; set; }

	[Column("localizedTextIdResourceAlert03")]
	public uint LocalizedTextIdResourceAlert03 { get; set; }

	[Column("localizedTextIdResourceAlert04")]
	public uint LocalizedTextIdResourceAlert04 { get; set; }

	[Column("localizedTextIdResourceAlert05")]
	public uint LocalizedTextIdResourceAlert05 { get; set; }

	[Column("localizedTextIdResourceAlert06")]
	public uint LocalizedTextIdResourceAlert06 { get; set; }

	[Column("localizedTextIdResourceAlert07")]
	public uint LocalizedTextIdResourceAlert07 { get; set; }

	[Column("attributeMilestoneGroupId00")]
	public uint AttributeMilestoneGroupId00 { get; set; }

	[Column("attributeMilestoneGroupId01")]
	public uint AttributeMilestoneGroupId01 { get; set; }

	[Column("attributeMilestoneGroupId02")]
	public uint AttributeMilestoneGroupId02 { get; set; }

	[Column("attributeMilestoneGroupId03")]
	public uint AttributeMilestoneGroupId03 { get; set; }

	[Column("attributeMilestoneGroupId04")]
	public uint AttributeMilestoneGroupId04 { get; set; }

	[Column("attributeMilestoneGroupId05")]
	public uint AttributeMilestoneGroupId05 { get; set; }

	[Column("classSecondaryStatBonusId00")]
	public uint ClassSecondaryStatBonusId00 { get; set; }

	[Column("classSecondaryStatBonusId01")]
	public uint ClassSecondaryStatBonusId01 { get; set; }

	[Column("classSecondaryStatBonusId02")]
	public uint ClassSecondaryStatBonusId02 { get; set; }

	[Column("classSecondaryStatBonusId03")]
	public uint ClassSecondaryStatBonusId03 { get; set; }

	[Column("classSecondaryStatBonusId04")]
	public uint ClassSecondaryStatBonusId04 { get; set; }

	[Column("classSecondaryStatBonusId05")]
	public uint ClassSecondaryStatBonusId05 { get; set; }

	[Column("attributeMiniMilestoneGroupId00")]
	public uint AttributeMiniMilestoneGroupId00 { get; set; }

	[Column("attributeMiniMilestoneGroupId01")]
	public uint AttributeMiniMilestoneGroupId01 { get; set; }

	[Column("attributeMiniMilestoneGroupId02")]
	public uint AttributeMiniMilestoneGroupId02 { get; set; }

	[Column("attributeMiniMilestoneGroupId03")]
	public uint AttributeMiniMilestoneGroupId03 { get; set; }

	[Column("attributeMiniMilestoneGroupId04")]
	public uint AttributeMiniMilestoneGroupId04 { get; set; }

	[Column("attributeMiniMilestoneGroupId05")]
	public uint AttributeMiniMilestoneGroupId05 { get; set; }

	[Column("attributeMilestoneMaxTiers00")]
	public uint AttributeMilestoneMaxTiers00 { get; set; }

	[Column("attributeMilestoneMaxTiers01")]
	public uint AttributeMilestoneMaxTiers01 { get; set; }

	[Column("attributeMilestoneMaxTiers02")]
	public uint AttributeMilestoneMaxTiers02 { get; set; }

	[Column("attributeMilestoneMaxTiers03")]
	public uint AttributeMilestoneMaxTiers03 { get; set; }

	[Column("attributeMilestoneMaxTiers04")]
	public uint AttributeMilestoneMaxTiers04 { get; set; }

	[Column("attributeMilestoneMaxTiers05")]
	public uint AttributeMilestoneMaxTiers05 { get; set; }
}
