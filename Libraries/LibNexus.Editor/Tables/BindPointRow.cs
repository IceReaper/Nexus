using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class BindPointRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("bindPointFactionEnum")]
	public uint BindPointFactionEnum { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }
}
