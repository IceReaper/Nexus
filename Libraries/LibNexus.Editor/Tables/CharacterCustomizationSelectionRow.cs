using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CharacterCustomizationSelectionRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("characterCustomizationLabelId")]
	public uint CharacterCustomizationLabelId { get; set; }

	[Column("value")]
	public uint Value { get; set; }

	[Column("cost")]
	public ulong Cost { get; set; }
}
