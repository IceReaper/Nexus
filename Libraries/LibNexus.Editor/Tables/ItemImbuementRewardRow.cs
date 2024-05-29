using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemImbuementRewardRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("itemImbuementRewardTypeEnum")]
	public uint ItemImbuementRewardTypeEnum { get; set; }

	[Column("rewardObjectId")]
	public uint RewardObjectId { get; set; }

	[Column("rewardValue")]
	public uint RewardValue { get; set; }

	[Column("rewardValueFloat")]
	public float RewardValueFloat { get; set; }
}
