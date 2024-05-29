using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class BugSubcategoryRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("bugCategoryId")]
	public uint BugCategoryId { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }
}
