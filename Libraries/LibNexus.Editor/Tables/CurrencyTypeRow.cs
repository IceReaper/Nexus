using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CurrencyTypeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("description")]
	public string Description { get; set; } = string.Empty;

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("iconName")]
	public string IconName { get; set; } = string.Empty;

	[Column("capAmount")]
	public ulong CapAmount { get; set; }
}
