using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class StoryPanelRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdBody")]
	public uint LocalizedTextIdBody { get; set; }

	[Column("soundEventId")]
	public uint SoundEventId { get; set; }

	[Column("windowTypeId")]
	public uint WindowTypeId { get; set; }

	[Column("durationMS")]
	public uint DurationMs { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[Column("storyPanelStyleEnum")]
	public uint StoryPanelStyleEnum { get; set; }
}
