using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MtxCategoryRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("idString")]
	public string IdString { get; set; } = string.Empty;

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("mtxCategoryIdParent")]
	public uint MtxCategoryIdParent { get; set; }
}
