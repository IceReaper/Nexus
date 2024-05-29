using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RewardPropertyPremiumModifierRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("premiumSystemEnum")]
	public uint PremiumSystemEnum { get; set; }

	[Column("tier")]
	public uint Tier { get; set; }

	[Column("rewardPropertyId")]
	public uint RewardPropertyId { get; set; }

	[Column("rewardPropertyData")]
	public uint RewardPropertyData { get; set; }

	[Column("modifierValueInt")]
	public uint ModifierValueInt { get; set; }

	[Column("modifierValueFloat")]
	public float ModifierValueFloat { get; set; }

	[Column("entitlementIdModifierCount")]
	public uint EntitlementIdModifierCount { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }
}
