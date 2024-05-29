using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelEventRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("EnumName")]
	public string EnumName { get; set; } = string.Empty;
}
