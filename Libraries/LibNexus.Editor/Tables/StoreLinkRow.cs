using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class StoreLinkRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("enumName")]
	public string EnumName { get; set; } = string.Empty;

	[Column("categoryData")]
	public uint CategoryData { get; set; }

	[Column("categoryDataPTR")]
	public uint CategoryDataPtr { get; set; }

	[Column("accountItemId")]
	public uint AccountItemId { get; set; }
}
