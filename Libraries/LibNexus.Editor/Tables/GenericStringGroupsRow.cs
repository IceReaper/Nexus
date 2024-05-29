using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class GenericStringGroupsRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }
}
