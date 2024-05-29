using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CharacterCreationRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("classId")]
	public uint ClassId { get; set; }

	[Column("raceId")]
	public uint RaceId { get; set; }

	[Column("sex")]
	public uint Sex { get; set; }

	[Column("factionId")]
	public uint FactionId { get; set; }

	[Column("costumeOnly")]
	public bool CostumeOnly { get; set; }

	[Column("itemId0")]
	public uint ItemId0 { get; set; }

	[Column("itemId01")]
	public uint ItemId01 { get; set; }

	[Column("itemId02")]
	public uint ItemId02 { get; set; }

	[Column("itemId03")]
	public uint ItemId03 { get; set; }

	[Column("itemId04")]
	public uint ItemId04 { get; set; }

	[Column("itemId05")]
	public uint ItemId05 { get; set; }

	[Column("itemId06")]
	public uint ItemId06 { get; set; }

	[Column("itemId07")]
	public uint ItemId07 { get; set; }

	[Column("itemId08")]
	public uint ItemId08 { get; set; }

	[Column("itemId09")]
	public uint ItemId09 { get; set; }

	[Column("itemId010")]
	public uint ItemId010 { get; set; }

	[Column("itemId011")]
	public uint ItemId011 { get; set; }

	[Column("itemId012")]
	public uint ItemId012 { get; set; }

	[Column("itemId013")]
	public uint ItemId013 { get; set; }

	[Column("itemId014")]
	public uint ItemId014 { get; set; }

	[Column("itemId015")]
	public uint ItemId015 { get; set; }

	[Column("enabled")]
	public bool Enabled { get; set; }

	[Column("characterCreationStartEnum")]
	public uint CharacterCreationStartEnum { get; set; }

	[Column("xp")]
	public uint Xp { get; set; }

	[Column("accountCurrencyTypeIdCost")]
	public uint AccountCurrencyTypeIdCost { get; set; }

	[Column("accountCurrencyAmountCost")]
	public uint AccountCurrencyAmountCost { get; set; }

	[Column("entitlementIdRequired")]
	public uint EntitlementIdRequired { get; set; }
}
