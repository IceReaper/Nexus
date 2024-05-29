using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SalvageRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("item2TypeId")]
	public uint Item2TypeId { get; set; }

	[Column("level")]
	public uint Level { get; set; }
}
