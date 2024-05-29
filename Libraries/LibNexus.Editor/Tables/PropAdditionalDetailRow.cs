using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PropAdditionalDetailRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }
}
