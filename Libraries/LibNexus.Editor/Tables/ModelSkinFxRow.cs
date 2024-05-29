using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelSkinFxRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("suffix")]
	public string Suffix { get; set; } = string.Empty;
}
