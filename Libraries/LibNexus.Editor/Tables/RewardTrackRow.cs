using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RewardTrackRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("rewardTrackTypeEnum")]
	public uint RewardTrackTypeEnum { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("localizedTextIdSummary")]
	public uint LocalizedTextIdSummary { get; set; }

	[Column("assetPathImage")]
	public string AssetPathImage { get; set; } = string.Empty;

	[Column("assetPathButtonImage")]
	public string AssetPathButtonImage { get; set; } = string.Empty;

	[Column("rewardPointCost00")]
	public uint RewardPointCost00 { get; set; }

	[Column("rewardPointCost01")]
	public uint RewardPointCost01 { get; set; }

	[Column("rewardPointCost02")]
	public uint RewardPointCost02 { get; set; }

	[Column("rewardPointCost03")]
	public uint RewardPointCost03 { get; set; }

	[Column("rewardPointCost04")]
	public uint RewardPointCost04 { get; set; }

	[Column("rewardPointCost05")]
	public uint RewardPointCost05 { get; set; }

	[Column("rewardPointCost06")]
	public uint RewardPointCost06 { get; set; }

	[Column("rewardPointCost07")]
	public uint RewardPointCost07 { get; set; }

	[Column("rewardPointCost08")]
	public uint RewardPointCost08 { get; set; }

	[Column("rewardPointCost09")]
	public uint RewardPointCost09 { get; set; }

	[Column("rewardTrackIdParent")]
	public uint RewardTrackIdParent { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }
}
