using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelClusterRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("EnumName")]
	public string EnumName { get; set; } = string.Empty;
}
