using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TutorialPageRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("tutorialId")]
	public uint TutorialId { get; set; }

	[Column("page")]
	public uint Page { get; set; }

	[Column("tutorialLayoutId")]
	public uint TutorialLayoutId { get; set; }

	[Column("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[Column("localizedTextIdBody00")]
	public uint LocalizedTextIdBody00 { get; set; }

	[Column("localizedTextIdBody01")]
	public uint LocalizedTextIdBody01 { get; set; }

	[Column("localizedTextIdBody02")]
	public uint LocalizedTextIdBody02 { get; set; }

	[Column("sprite00")]
	public string Sprite00 { get; set; } = string.Empty;

	[Column("sprite01")]
	public string Sprite01 { get; set; } = string.Empty;

	[Column("sprite02")]
	public string Sprite02 { get; set; } = string.Empty;

	[Column("soundEventId")]
	public uint SoundEventId { get; set; }
}
