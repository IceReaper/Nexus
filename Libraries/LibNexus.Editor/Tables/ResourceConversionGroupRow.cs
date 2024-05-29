using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ResourceConversionGroupRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("resourceConversionId00")]
	public uint ResourceConversionId00 { get; set; }

	[Column("resourceConversionId01")]
	public uint ResourceConversionId01 { get; set; }

	[Column("resourceConversionId02")]
	public uint ResourceConversionId02 { get; set; }

	[Column("resourceConversionId03")]
	public uint ResourceConversionId03 { get; set; }

	[Column("resourceConversionId04")]
	public uint ResourceConversionId04 { get; set; }

	[Column("resourceConversionId05")]
	public uint ResourceConversionId05 { get; set; }
}
