using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Quest2RewardRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("quest2Id")]
	public uint Quest2Id { get; set; }

	[Column("quest2RewardTypeId")]
	public uint Quest2RewardTypeId { get; set; }

	[Column("objectId")]
	public uint ObjectId { get; set; }

	[Column("objectAmount")]
	public uint ObjectAmount { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }
}
