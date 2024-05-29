using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4VisualRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("targetTypeFlags")]
	public uint TargetTypeFlags { get; set; }

	[Column("stageType")]
	public uint StageType { get; set; }

	[Column("stageFlags")]
	public uint StageFlags { get; set; }

	[Column("visualEffectId")]
	public uint VisualEffectId { get; set; }

	[Column("visualEffectIdSound")]
	public uint VisualEffectIdSound { get; set; }

	[Column("modelEventIdDelay")]
	public uint ModelEventIdDelay { get; set; }

	[Column("soundEventType00")]
	public uint SoundEventType00 { get; set; }

	[Column("soundEventType01")]
	public uint SoundEventType01 { get; set; }

	[Column("soundEventType02")]
	public uint SoundEventType02 { get; set; }

	[Column("soundEventType03")]
	public uint SoundEventType03 { get; set; }

	[Column("soundEventType04")]
	public uint SoundEventType04 { get; set; }

	[Column("soundEventType05")]
	public uint SoundEventType05 { get; set; }

	[Column("soundImpactDescriptionIdTarget00")]
	public uint SoundImpactDescriptionIdTarget00 { get; set; }

	[Column("soundImpactDescriptionIdTarget01")]
	public uint SoundImpactDescriptionIdTarget01 { get; set; }

	[Column("soundImpactDescriptionIdTarget02")]
	public uint SoundImpactDescriptionIdTarget02 { get; set; }

	[Column("soundImpactDescriptionIdTarget03")]
	public uint SoundImpactDescriptionIdTarget03 { get; set; }

	[Column("soundImpactDescriptionIdTarget04")]
	public uint SoundImpactDescriptionIdTarget04 { get; set; }

	[Column("soundImpactDescriptionIdTarget05")]
	public uint SoundImpactDescriptionIdTarget05 { get; set; }

	[Column("soundImpactDescriptionIdOrigin00")]
	public uint SoundImpactDescriptionIdOrigin00 { get; set; }

	[Column("soundImpactDescriptionIdOrigin01")]
	public uint SoundImpactDescriptionIdOrigin01 { get; set; }

	[Column("soundImpactDescriptionIdOrigin02")]
	public uint SoundImpactDescriptionIdOrigin02 { get; set; }

	[Column("soundImpactDescriptionIdOrigin03")]
	public uint SoundImpactDescriptionIdOrigin03 { get; set; }

	[Column("soundImpactDescriptionIdOrigin04")]
	public uint SoundImpactDescriptionIdOrigin04 { get; set; }

	[Column("soundImpactDescriptionIdOrigin05")]
	public uint SoundImpactDescriptionIdOrigin05 { get; set; }

	[Column("modelAttachmentIdCaster")]
	public uint ModelAttachmentIdCaster { get; set; }

	[Column("phaseFlags")]
	public uint PhaseFlags { get; set; }

	[Column("modelOffsetX")]
	public float ModelOffsetX { get; set; }

	[Column("modelOffsetY")]
	public float ModelOffsetY { get; set; }

	[Column("modelOffsetZ")]
	public float ModelOffsetZ { get; set; }

	[Column("modelScale")]
	public float ModelScale { get; set; }

	[Column("preDelayTimeMs")]
	public uint PreDelayTimeMs { get; set; }

	[Column("telegraphDamageIdAttach")]
	public uint TelegraphDamageIdAttach { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }
}
