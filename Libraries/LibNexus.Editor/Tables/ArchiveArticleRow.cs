using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ArchiveArticleRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("creature2IdPortrait")]
	public uint Creature2IdPortrait { get; set; }

	[Column("iconAssetPath")]
	public string IconAssetPath { get; set; } = string.Empty;

	[Column("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

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

	[Column("archiveEntryId00")]
	public uint ArchiveEntryId00 { get; set; }

	[Column("archiveEntryId01")]
	public uint ArchiveEntryId01 { get; set; }

	[Column("archiveEntryId02")]
	public uint ArchiveEntryId02 { get; set; }

	[Column("archiveEntryId03")]
	public uint ArchiveEntryId03 { get; set; }

	[Column("archiveEntryId04")]
	public uint ArchiveEntryId04 { get; set; }

	[Column("archiveEntryId05")]
	public uint ArchiveEntryId05 { get; set; }

	[Column("archiveEntryId06")]
	public uint ArchiveEntryId06 { get; set; }

	[Column("archiveEntryId07")]
	public uint ArchiveEntryId07 { get; set; }

	[Column("archiveEntryId08")]
	public uint ArchiveEntryId08 { get; set; }

	[Column("archiveEntryId09")]
	public uint ArchiveEntryId09 { get; set; }

	[Column("archiveEntryId10")]
	public uint ArchiveEntryId10 { get; set; }

	[Column("archiveEntryId11")]
	public uint ArchiveEntryId11 { get; set; }

	[Column("archiveEntryId12")]
	public uint ArchiveEntryId12 { get; set; }

	[Column("archiveEntryId13")]
	public uint ArchiveEntryId13 { get; set; }

	[Column("archiveEntryId14")]
	public uint ArchiveEntryId14 { get; set; }

	[Column("archiveEntryId15")]
	public uint ArchiveEntryId15 { get; set; }

	[Column("archiveArticleFlags")]
	public uint ArchiveArticleFlags { get; set; }

	[Column("archiveCategoryId00")]
	public uint ArchiveCategoryId00 { get; set; }

	[Column("archiveCategoryId01")]
	public uint ArchiveCategoryId01 { get; set; }

	[Column("archiveCategoryId02")]
	public uint ArchiveCategoryId02 { get; set; }

	[Column("localizedTextIdToolTip")]
	public uint LocalizedTextIdToolTip { get; set; }

	[Column("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[Column("characterTitleIdReward")]
	public uint CharacterTitleIdReward { get; set; }

	[Column("linkName")]
	public string LinkName { get; set; } = string.Empty;
}
