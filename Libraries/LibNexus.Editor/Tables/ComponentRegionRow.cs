using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ComponentRegionRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("EnumName")]
	public string EnumName { get; set; } = string.Empty;

	[Column("componentMap")]
	public uint ComponentMap { get; set; }
}
