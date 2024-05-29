using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MaterialTypeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("MaterialFlags")]
	public uint MaterialFlags { get; set; }
}
