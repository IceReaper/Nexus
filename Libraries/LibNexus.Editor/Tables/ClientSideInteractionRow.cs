using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ClientSideInteractionRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("interactionType")]
	public uint InteractionType { get; set; }

	[Column("threshold")]
	public uint Threshold { get; set; }

	[Column("duration")]
	public uint Duration { get; set; }

	[Column("incrementValue")]
	public uint IncrementValue { get; set; }

	[Column("windowSize")]
	public uint WindowSize { get; set; }

	[Column("decay")]
	public uint Decay { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("tapTime0")]
	public uint TapTime0 { get; set; }

	[Column("tapTime1")]
	public uint TapTime1 { get; set; }

	[Column("visualEffectId0")]
	public uint VisualEffectId0 { get; set; }

	[Column("visualEffectId1")]
	public uint VisualEffectId1 { get; set; }

	[Column("visualEffectId2")]
	public uint VisualEffectId2 { get; set; }

	[Column("visualEffectId3")]
	public uint VisualEffectId3 { get; set; }

	[Column("visualEffectIdTarget00")]
	public uint VisualEffectIdTarget00 { get; set; }

	[Column("visualEffectIdTarget01")]
	public uint VisualEffectIdTarget01 { get; set; }

	[Column("visualEffectIdTarget02")]
	public uint VisualEffectIdTarget02 { get; set; }

	[Column("visualEffectIdTarget03")]
	public uint VisualEffectIdTarget03 { get; set; }

	[Column("visualEffectIdTarget04")]
	public uint VisualEffectIdTarget04 { get; set; }

	[Column("visualEffectIdCaster00")]
	public uint VisualEffectIdCaster00 { get; set; }

	[Column("visualEffectIdCaster01")]
	public uint VisualEffectIdCaster01 { get; set; }

	[Column("visualEffectIdCaster02")]
	public uint VisualEffectIdCaster02 { get; set; }

	[Column("visualEffectIdCaster03")]
	public uint VisualEffectIdCaster03 { get; set; }

	[Column("visualEffectIdCaster04")]
	public uint VisualEffectIdCaster04 { get; set; }

	[Column("localizedTextIdContext")]
	public uint LocalizedTextIdContext { get; set; }
}
