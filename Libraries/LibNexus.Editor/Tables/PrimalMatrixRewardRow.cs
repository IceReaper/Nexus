using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PrimalMatrixRewardRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("primalMatrixRewardTypeEnum0")]
	public uint PrimalMatrixRewardTypeEnum0 { get; set; }

	[Column("primalMatrixRewardTypeEnum1")]
	public uint PrimalMatrixRewardTypeEnum1 { get; set; }

	[Column("primalMatrixRewardTypeEnum2")]
	public uint PrimalMatrixRewardTypeEnum2 { get; set; }

	[Column("primalMatrixRewardTypeEnum3")]
	public uint PrimalMatrixRewardTypeEnum3 { get; set; }

	[Column("objectId0")]
	public uint ObjectId0 { get; set; }

	[Column("objectId1")]
	public uint ObjectId1 { get; set; }

	[Column("objectId2")]
	public uint ObjectId2 { get; set; }

	[Column("objectId3")]
	public uint ObjectId3 { get; set; }

	[Column("subObjectId0")]
	public uint SubObjectId0 { get; set; }

	[Column("subObjectId1")]
	public uint SubObjectId1 { get; set; }

	[Column("subObjectId2")]
	public uint SubObjectId2 { get; set; }

	[Column("subObjectId3")]
	public uint SubObjectId3 { get; set; }

	[Column("value0")]
	public float Value0 { get; set; }

	[Column("value1")]
	public float Value1 { get; set; }

	[Column("value2")]
	public float Value2 { get; set; }

	[Column("value3")]
	public float Value3 { get; set; }
}
