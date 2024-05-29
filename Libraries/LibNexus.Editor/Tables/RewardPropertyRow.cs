using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RewardPropertyRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("rewardModifierValueTypeEnum")]
	public uint RewardModifierValueTypeEnum { get; set; }
}