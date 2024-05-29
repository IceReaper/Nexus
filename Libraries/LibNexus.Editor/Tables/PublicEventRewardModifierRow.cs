using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventRewardModifierRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("publicEventId")]
	public uint PublicEventId { get; set; }

	[Column("rewardPropertyId")]
	public uint RewardPropertyId { get; set; }

	[Column("data")]
	public uint Data { get; set; }

	[Column("offset")]
	public float Offset { get; set; }
}
