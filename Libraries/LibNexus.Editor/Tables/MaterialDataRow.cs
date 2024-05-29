using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MaterialDataRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("row")]
	public uint Row { get; set; }

	[Column("materialTypeId")]
	public uint MaterialTypeId { get; set; }
}
