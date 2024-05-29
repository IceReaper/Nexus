using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class AccountItemRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("item2Id")]
	public uint Item2Id { get; set; }

	[Column("entitlementId")]
	public uint EntitlementId { get; set; }

	[Column("entitlementCount")]
	public uint EntitlementCount { get; set; }

	[Column("entitlementScopeEnum")]
	public uint EntitlementScopeEnum { get; set; }

	[Column("instantEventEnum")]
	public uint InstantEventEnum { get; set; }

	[Column("accountCurrencyEnum")]
	public uint AccountCurrencyEnum { get; set; }

	[Column("accountCurrencyAmount")]
	public ulong AccountCurrencyAmount { get; set; }

	[Column("buttonIcon")]
	public string ButtonIcon { get; set; } = string.Empty;

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[Column("accountItemCooldownGroupId")]
	public uint AccountItemCooldownGroupId { get; set; }

	[Column("storeDisplayInfoId")]
	public uint StoreDisplayInfoId { get; set; }

	[Column("storeIdentifierUpsell")]
	public string StoreIdentifierUpsell { get; set; } = string.Empty;

	[Column("creature2DisplayGroupIdGacha")]
	public uint Creature2DisplayGroupIdGacha { get; set; }

	[Column("entitlementIdPurchase")]
	public uint EntitlementIdPurchase { get; set; }

	[Column("genericUnlockSetId")]
	public uint GenericUnlockSetId { get; set; }
}
