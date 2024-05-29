using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class InputActionRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("enumName")]
	public string EnumName { get; set; } = string.Empty;

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("inputActionCategoryId")]
	public uint InputActionCategoryId { get; set; }

	[Column("canHaveUpDownState")]
	public bool CanHaveUpDownState { get; set; }

	[Column("displayIndex")]
	public uint DisplayIndex { get; set; }
}
