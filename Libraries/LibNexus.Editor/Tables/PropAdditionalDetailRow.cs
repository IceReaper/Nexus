using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PropAdditionalDetailRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }
}
