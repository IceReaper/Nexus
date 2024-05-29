using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CostumeSpeciesRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("componentLayoutId")]
	public uint ComponentLayoutId { get; set; }

	[Column("enumName")]
	public string EnumName { get; set; } = string.Empty;
}
