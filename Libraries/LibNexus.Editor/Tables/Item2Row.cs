using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Item2Row
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("itemBudgetId")]
	public uint ItemBudgetId { get; set; }

	[Column("itemStatId")]
	public uint ItemStatId { get; set; }

	[Column("itemRuneInstanceId")]
	public uint ItemRuneInstanceId { get; set; }

	[Column("itemQualityId")]
	public uint ItemQualityId { get; set; }

	[Column("itemSpecialId00")]
	public uint ItemSpecialId00 { get; set; }

	[Column("itemImbuementId")]
	public uint ItemImbuementId { get; set; }

	[Column("item2FamilyId")]
	public uint Item2FamilyId { get; set; }

	[Column("item2CategoryId")]
	public uint Item2CategoryId { get; set; }

	[Column("item2TypeId")]
	public uint Item2TypeId { get; set; }

	[Column("itemDisplayId")]
	public uint ItemDisplayId { get; set; }

	[Column("itemSourceId")]
	public uint ItemSourceId { get; set; }

	[Column("classRequired")]
	public uint ClassRequired { get; set; }

	[Column("raceRequired")]
	public uint RaceRequired { get; set; }

	[Column("faction2IdRequired")]
	public uint Faction2IdRequired { get; set; }

	[Column("powerLevel")]
	public uint PowerLevel { get; set; }

	[Column("requiredLevel")]
	public uint RequiredLevel { get; set; }

	[Column("requiredItemLevel")]
	public uint RequiredItemLevel { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[Column("equippedSlotFlags")]
	public uint EquippedSlotFlags { get; set; }

	[Column("maxStackCount")]
	public uint MaxStackCount { get; set; }

	[Column("maxCharges")]
	public uint MaxCharges { get; set; }

	[Column("expirationTimeMinutes")]
	public uint ExpirationTimeMinutes { get; set; }

	[Column("quest2IdActivation")]
	public uint Quest2IdActivation { get; set; }

	[Column("quest2IdActivationRequired")]
	public uint Quest2IdActivationRequired { get; set; }

	[Column("questObjectiveActivationRequired")]
	public uint QuestObjectiveActivationRequired { get; set; }

	[Column("tradeskillAdditiveId")]
	public uint TradeskillAdditiveId { get; set; }

	[Column("tradeskillCatalystId")]
	public uint TradeskillCatalystId { get; set; }

	[Column("housingDecorInfoId")]
	public uint HousingDecorInfoId { get; set; }

	[Column("housingWarplotBossTokenId")]
	public uint HousingWarplotBossTokenId { get; set; }

	[Column("genericUnlockSetId")]
	public uint GenericUnlockSetId { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("bindFlags")]
	public uint BindFlags { get; set; }

	[Column("buyFromVendorStackCount")]
	public uint BuyFromVendorStackCount { get; set; }

	[Column("currencyTypeId0")]
	public uint CurrencyTypeId0 { get; set; }

	[Column("currencyTypeId1")]
	public uint CurrencyTypeId1 { get; set; }

	[Column("currencyAmount0")]
	public uint CurrencyAmount0 { get; set; }

	[Column("currencyAmount1")]
	public uint CurrencyAmount1 { get; set; }

	[Column("currencyTypeId0SellToVendor")]
	public uint CurrencyTypeId0SellToVendor { get; set; }

	[Column("currencyTypeId1SellToVendor")]
	public uint CurrencyTypeId1SellToVendor { get; set; }

	[Column("currencyAmount0SellToVendor")]
	public uint CurrencyAmount0SellToVendor { get; set; }

	[Column("currencyAmount1SellToVendor")]
	public uint CurrencyAmount1SellToVendor { get; set; }

	[Column("itemColorSetId")]
	public uint ItemColorSetId { get; set; }

	[Column("supportPowerPercentage")]
	public float SupportPowerPercentage { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdTooltip")]
	public uint LocalizedTextIdTooltip { get; set; }

	[Column("buttonTemplate")]
	public string ButtonTemplate { get; set; } = string.Empty;

	[Column("buttonIcon")]
	public string ButtonIcon { get; set; } = string.Empty;

	[Column("soundEventIdEquip")]
	public uint SoundEventIdEquip { get; set; }
}
