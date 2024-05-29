using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Item2CategoryRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("itemProficiencyId")]
	public uint ItemProficiencyId { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("tradeSkillId")]
	public uint TradeSkillId { get; set; }

	[Column("soundEventIdEquip")]
	public uint SoundEventIdEquip { get; set; }

	[Column("vendorMultiplier")]
	public float VendorMultiplier { get; set; }

	[Column("turninMultiplier")]
	public float TurninMultiplier { get; set; }

	[Column("armorModifier")]
	public float ArmorModifier { get; set; }

	[Column("armorBase")]
	public float ArmorBase { get; set; }

	[Column("weaponPowerModifier")]
	public float WeaponPowerModifier { get; set; }

	[Column("weaponPowerBase")]
	public uint WeaponPowerBase { get; set; }

	[Column("item2FamilyId")]
	public uint Item2FamilyId { get; set; }
}
