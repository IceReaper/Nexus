using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Faction2Row
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("faction2IdParent")]
	public uint Faction2IdParent { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdToolTip")]
	public uint LocalizedTextIdToolTip { get; set; }

	[Column("orderIndex")]
	public uint OrderIndex { get; set; }

	[Column("archiveArticleId")]
	public uint ArchiveArticleId { get; set; }
}
