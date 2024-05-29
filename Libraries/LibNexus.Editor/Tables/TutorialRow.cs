using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TutorialRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("tutorialCategoryEnum")]
	public uint TutorialCategoryEnum { get; set; }

	[Column("localizedTextIdContextualPopup")]
	public uint LocalizedTextIdContextualPopup { get; set; }

	[Column("tutorialAnchorId")]
	public uint TutorialAnchorId { get; set; }

	[Column("requiredLevel")]
	public uint RequiredLevel { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }
}
