using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ArchiveEntryUnlockRuleRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("archiveEntryId")]
	public uint ArchiveEntryId { get; set; }

	[Column("archiveEntryUnlockRuleEnum")]
	public uint ArchiveEntryUnlockRuleEnum { get; set; }

	[Column("archiveEntryUnlockRuleFlags")]
	public uint ArchiveEntryUnlockRuleFlags { get; set; }

	[Column("object00")]
	public uint Object00 { get; set; }

	[Column("object01")]
	public uint Object01 { get; set; }

	[Column("object02")]
	public uint Object02 { get; set; }

	[Column("object03")]
	public uint Object03 { get; set; }

	[Column("object04")]
	public uint Object04 { get; set; }

	[Column("object05")]
	public uint Object05 { get; set; }
}
