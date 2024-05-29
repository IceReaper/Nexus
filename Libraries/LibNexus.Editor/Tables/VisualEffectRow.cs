using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class VisualEffectRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("visualType")]
	public uint VisualType { get; set; }

	[Column("startDelay")]
	public uint StartDelay { get; set; }

	[Column("duration")]
	public uint Duration { get; set; }

	[Column("modelItemSlot")]
	public uint ModelItemSlot { get; set; }

	[Column("modelItemCostumeSide")]
	public uint ModelItemCostumeSide { get; set; }

	[Column("modelAssetPath")]
	public string ModelAssetPath { get; set; } = string.Empty;

	[Column("modelAttachmentId")]
	public uint ModelAttachmentId { get; set; }

	[Column("modelSequencePriority")]
	public uint ModelSequencePriority { get; set; }

	[Column("modelSequenceIdTarget00")]
	public uint ModelSequenceIdTarget00 { get; set; }

	[Column("modelSequenceIdTarget01")]
	public uint ModelSequenceIdTarget01 { get; set; }

	[Column("modelSequenceIdTarget02")]
	public uint ModelSequenceIdTarget02 { get; set; }

	[Column("modelScale")]
	public float ModelScale { get; set; }

	[Column("modelRotationX")]
	public float ModelRotationX { get; set; }

	[Column("modelRotationY")]
	public float ModelRotationY { get; set; }

	[Column("modelRotationZ")]
	public float ModelRotationZ { get; set; }

	[Column("data00")]
	public float Data00 { get; set; }

	[Column("data01")]
	public float Data01 { get; set; }

	[Column("data02")]
	public float Data02 { get; set; }

	[Column("data03")]
	public float Data03 { get; set; }

	[Column("data04")]
	public float Data04 { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("soundEventId00")]
	public uint SoundEventId00 { get; set; }

	[Column("soundEventId01")]
	public uint SoundEventId01 { get; set; }

	[Column("soundEventId02")]
	public uint SoundEventId02 { get; set; }

	[Column("soundEventId03")]
	public uint SoundEventId03 { get; set; }

	[Column("soundEventId04")]
	public uint SoundEventId04 { get; set; }

	[Column("soundEventId05")]
	public uint SoundEventId05 { get; set; }

	[Column("soundEventOffset00")]
	public uint SoundEventOffset00 { get; set; }

	[Column("soundEventOffset01")]
	public uint SoundEventOffset01 { get; set; }

	[Column("soundEventOffset02")]
	public uint SoundEventOffset02 { get; set; }

	[Column("soundEventOffset03")]
	public uint SoundEventOffset03 { get; set; }

	[Column("soundEventOffset04")]
	public uint SoundEventOffset04 { get; set; }

	[Column("soundEventOffset05")]
	public uint SoundEventOffset05 { get; set; }

	[Column("soundEventIdStop")]
	public uint SoundEventIdStop { get; set; }

	[Column("soundZoneKitId")]
	public uint SoundZoneKitId { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[Column("particleDiffuseColor")]
	public uint ParticleDiffuseColor { get; set; }
}
