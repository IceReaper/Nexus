using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4BaseRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("spell4HitResultId")]
	public uint Spell4HitResultId { get; set; }

	[Column("spell4TargetMechanicId")]
	public uint Spell4TargetMechanicId { get; set; }

	[Column("spell4TargetAngleId")]
	public uint Spell4TargetAngleId { get; set; }

	[Column("spell4PrerequisiteId")]
	public uint Spell4PrerequisiteId { get; set; }

	[Column("spell4ValidTargetId")]
	public uint Spell4ValidTargetId { get; set; }

	[Column("targetGroupIdCastGroup")]
	public uint TargetGroupIdCastGroup { get; set; }

	[Column("creature2IdPositionalAoe")]
	public uint Creature2IdPositionalAoe { get; set; }

	[Column("parameterAEAngle")]
	public float ParameterAeAngle { get; set; }

	[Column("parameterAEMaxAngle")]
	public float ParameterAeMaxAngle { get; set; }

	[Column("parameterAEDistance")]
	public float ParameterAeDistance { get; set; }

	[Column("parameterAEMaxDistance")]
	public float ParameterAeMaxDistance { get; set; }

	[Column("targetGroupIdAoeGroup")]
	public uint TargetGroupIdAoeGroup { get; set; }

	[Column("spell4BaseIdPrerequisiteSpell")]
	public uint Spell4BaseIdPrerequisiteSpell { get; set; }

	[Column("worldZoneIdZoneRequired")]
	public uint WorldZoneIdZoneRequired { get; set; }

	[Column("spell4SpellTypesIdSpellType")]
	public uint Spell4SpellTypesIdSpellType { get; set; }

	[Column("icon")]
	public string Icon { get; set; } = string.Empty;

	[Column("castMethod")]
	public uint CastMethod { get; set; }

	[Column("school")]
	public uint School { get; set; }

	[Column("spellClass")]
	public uint SpellClass { get; set; }

	[Column("weaponSlot")]
	public uint WeaponSlot { get; set; }

	[Column("castBarType")]
	public uint CastBarType { get; set; }

	[Column("mechanicAggressionMagnitude")]
	public float MechanicAggressionMagnitude { get; set; }

	[Column("mechanicDominationMagnitude")]
	public float MechanicDominationMagnitude { get; set; }

	[Column("modelSequencePriorityCaster")]
	public uint ModelSequencePriorityCaster { get; set; }

	[Column("modelSequencePriorityTarget")]
	public uint ModelSequencePriorityTarget { get; set; }

	[Column("classIdPlayer")]
	public uint ClassIdPlayer { get; set; }

	[Column("clientSideInteractionId")]
	public uint ClientSideInteractionId { get; set; }

	[Column("targetingFlags")]
	public uint TargetingFlags { get; set; }

	[Column("telegraphFlagsEnum")]
	public uint TelegraphFlagsEnum { get; set; }

	[Column("localizedTextIdLASTierPoint")]
	public uint LocalizedTextIdLasTierPoint { get; set; }

	[Column("lasTierPointTooltipData00")]
	public float LasTierPointTooltipData00 { get; set; }

	[Column("lasTierPointTooltipData01")]
	public float LasTierPointTooltipData01 { get; set; }

	[Column("lasTierPointTooltipData02")]
	public float LasTierPointTooltipData02 { get; set; }

	[Column("lasTierPointTooltipData03")]
	public float LasTierPointTooltipData03 { get; set; }

	[Column("lasTierPointTooltipData04")]
	public float LasTierPointTooltipData04 { get; set; }

	[Column("lasTierPointTooltipData05")]
	public float LasTierPointTooltipData05 { get; set; }

	[Column("lasTierPointTooltipData06")]
	public float LasTierPointTooltipData06 { get; set; }

	[Column("lasTierPointTooltipData07")]
	public float LasTierPointTooltipData07 { get; set; }

	[Column("lasTierPointTooltipData08")]
	public float LasTierPointTooltipData08 { get; set; }

	[Column("lasTierPointTooltipData09")]
	public float LasTierPointTooltipData09 { get; set; }
}
