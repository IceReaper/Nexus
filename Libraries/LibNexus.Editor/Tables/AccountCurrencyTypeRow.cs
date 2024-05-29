using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class AccountCurrencyTypeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("iconName")]
	public string IconName { get; set; } = string.Empty;

	[Column("accountItemId")]
	public uint AccountItemId { get; set; }
}
