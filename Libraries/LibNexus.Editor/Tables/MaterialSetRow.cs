using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MaterialSetRow
{
	[Column("ID")]
	public uint Id { get; set; }
}
