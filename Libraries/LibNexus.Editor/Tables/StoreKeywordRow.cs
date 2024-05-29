using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class StoreKeywordRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("storeDisplayInfoId")]
	public uint StoreDisplayInfoId { get; set; }

	[Column("keyword")]
	public string Keyword { get; set; } = string.Empty;
}
