using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MaterialRemapRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("materialDataRow")]
	public uint MaterialDataRow { get; set; }

	[Column("materialSetId")]
	public uint MaterialSetId { get; set; }

	[Column("materialDataRowRemap")]
	public uint MaterialDataRowRemap { get; set; }
}
