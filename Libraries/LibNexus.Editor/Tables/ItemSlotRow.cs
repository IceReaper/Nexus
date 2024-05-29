using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemSlotRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("EnumName")]
	public string EnumName { get; set; } = string.Empty;

	[Column("equippedSlotFlags")]
	public uint EquippedSlotFlags { get; set; }

	[Column("armorModifier")]
	public float ArmorModifier { get; set; }

	[Column("itemLevelModifier")]
	public float ItemLevelModifier { get; set; }

	[Column("slotBonus")]
	public uint SlotBonus { get; set; }

	[Column("glyphSlotBonus")]
	public uint GlyphSlotBonus { get; set; }

	[Column("minLevel")]
	public uint MinLevel { get; set; }
}
