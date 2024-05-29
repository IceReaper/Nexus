using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ArchiveEntryRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdHeading")]
	public uint LocalizedTextIdHeading { get; set; }

	[Column("localizedTextIdText00")]
	public uint LocalizedTextIdText00 { get; set; }

	[Column("localizedTextIdText01")]
	public uint LocalizedTextIdText01 { get; set; }

	[Column("localizedTextIdText02")]
	public uint LocalizedTextIdText02 { get; set; }

	[Column("localizedTextIdText03")]
	public uint LocalizedTextIdText03 { get; set; }

	[Column("localizedTextIdText04")]
	public uint LocalizedTextIdText04 { get; set; }

	[Column("localizedTextIdText05")]
	public uint LocalizedTextIdText05 { get; set; }

	[Column("localizedTextIdTextScientist00")]
	public uint LocalizedTextIdTextScientist00 { get; set; }

	[Column("localizedTextIdTextScientist01")]
	public uint LocalizedTextIdTextScientist01 { get; set; }

	[Column("localizedTextIdTextScientist02")]
	public uint LocalizedTextIdTextScientist02 { get; set; }

	[Column("localizedTextIdTextScientist03")]
	public uint LocalizedTextIdTextScientist03 { get; set; }

	[Column("localizedTextIdTextScientist04")]
	public uint LocalizedTextIdTextScientist04 { get; set; }

	[Column("localizedTextIdTextScientist05")]
	public uint LocalizedTextIdTextScientist05 { get; set; }

	[Column("creature2IdPortrait")]
	public uint Creature2IdPortrait { get; set; }

	[Column("iconAssetPath")]
	public string IconAssetPath { get; set; } = string.Empty;

	[Column("inlineAssetPath")]
	public string InlineAssetPath { get; set; } = string.Empty;

	[Column("archiveEntryTypeEnum")]
	public uint ArchiveEntryTypeEnum { get; set; }

	[Column("archiveEntryFlags")]
	public uint ArchiveEntryFlags { get; set; }

	[Column("archiveEntryHeaderEnum")]
	public uint ArchiveEntryHeaderEnum { get; set; }

	[Column("characterTitleIdReward")]
	public uint CharacterTitleIdReward { get; set; }
}
