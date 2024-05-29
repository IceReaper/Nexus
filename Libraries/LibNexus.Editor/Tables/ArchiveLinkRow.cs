using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ArchiveLinkRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("archiveArticleIdParent")]
	public uint ArchiveArticleIdParent { get; set; }

	[Column("archiveArticleIdChild")]
	public uint ArchiveArticleIdChild { get; set; }

	[Column("archiveLinkFlags")]
	public uint ArchiveLinkFlags { get; set; }
}
