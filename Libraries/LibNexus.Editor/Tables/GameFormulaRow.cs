using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class GameFormulaRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("dataint0")]
	public uint Dataint0 { get; set; }

	[Column("dataint01")]
	public uint Dataint01 { get; set; }

	[Column("dataint02")]
	public uint Dataint02 { get; set; }

	[Column("dataint03")]
	public uint Dataint03 { get; set; }

	[Column("dataint04")]
	public uint Dataint04 { get; set; }

	[Column("datafloat0")]
	public float Datafloat0 { get; set; }

	[Column("datafloat01")]
	public float Datafloat01 { get; set; }

	[Column("datafloat02")]
	public float Datafloat02 { get; set; }

	[Column("datafloat03")]
	public float Datafloat03 { get; set; }

	[Column("datafloat04")]
	public float Datafloat04 { get; set; }
}
