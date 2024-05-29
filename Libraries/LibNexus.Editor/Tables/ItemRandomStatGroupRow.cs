using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemRandomStatGroupRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }
}
