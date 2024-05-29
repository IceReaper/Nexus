using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CcStateAdditionalDataRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("ccStatesId")]
	public uint CcStatesId { get; set; }

	[Column("dataInt00")]
	public uint DataInt00 { get; set; }

	[Column("dataInt01")]
	public uint DataInt01 { get; set; }

	[Column("dataInt02")]
	public uint DataInt02 { get; set; }

	[Column("dataInt03")]
	public uint DataInt03 { get; set; }

	[Column("dataInt04")]
	public uint DataInt04 { get; set; }

	[Column("dataFloat00")]
	public float DataFloat00 { get; set; }

	[Column("dataFloat01")]
	public float DataFloat01 { get; set; }

	[Column("dataFloat02")]
	public float DataFloat02 { get; set; }

	[Column("dataFloat03")]
	public float DataFloat03 { get; set; }

	[Column("dataFloat04")]
	public float DataFloat04 { get; set; }
}
