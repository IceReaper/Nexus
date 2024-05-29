using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class UnitProperty2Row
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("description")]
	public string Description { get; set; } = string.Empty;

	[Column("enumName")]
	public string EnumName { get; set; } = string.Empty;

	[Column("defaultValue")]
	public float DefaultValue { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("valuePerPoint")]
	public float ValuePerPoint { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("tooltipDisplayOrder")]
	public uint TooltipDisplayOrder { get; set; }

	[Column("profiencyFlagEnum")]
	public uint ProfiencyFlagEnum { get; set; }

	[Column("itemCraftingGroupFlagBitMask")]
	public uint ItemCraftingGroupFlagBitMask { get; set; }

	[Column("equippedSlotFlags")]
	public uint EquippedSlotFlags { get; set; }
}
