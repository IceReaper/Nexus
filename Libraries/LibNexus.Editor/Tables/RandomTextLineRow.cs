using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RandomTextLineRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("randomTextLineSetId")]
	public uint RandomTextLineSetId { get; set; }
}
