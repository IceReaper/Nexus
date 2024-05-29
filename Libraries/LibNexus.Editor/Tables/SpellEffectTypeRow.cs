using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SpellEffectTypeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("dataType00")]
	public uint DataType00 { get; set; }

	[Column("dataType01")]
	public uint DataType01 { get; set; }

	[Column("dataType02")]
	public uint DataType02 { get; set; }

	[Column("dataType03")]
	public uint DataType03 { get; set; }

	[Column("dataType04")]
	public uint DataType04 { get; set; }

	[Column("dataType05")]
	public uint DataType05 { get; set; }

	[Column("dataType06")]
	public uint DataType06 { get; set; }

	[Column("dataType07")]
	public uint DataType07 { get; set; }

	[Column("dataType08")]
	public uint DataType08 { get; set; }

	[Column("dataType09")]
	public uint DataType09 { get; set; }
}
