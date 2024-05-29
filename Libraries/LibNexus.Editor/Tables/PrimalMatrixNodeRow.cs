using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PrimalMatrixNodeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("positionX")]
	public uint PositionX { get; set; }

	[Column("positionY")]
	public uint PositionY { get; set; }

	[Column("primalMatrixNodeTypeEnum")]
	public uint PrimalMatrixNodeTypeEnum { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("maxAllocations")]
	public uint MaxAllocations { get; set; }

	[Column("costRedEssence")]
	public uint CostRedEssence { get; set; }

	[Column("costBlueEssence")]
	public uint CostBlueEssence { get; set; }

	[Column("costGreenEssence")]
	public uint CostGreenEssence { get; set; }

	[Column("costPurpleEssence")]
	public uint CostPurpleEssence { get; set; }

	[Column("primalMatrixRewardIdWarrior")]
	public uint PrimalMatrixRewardIdWarrior { get; set; }

	[Column("primalMatrixRewardIdEngineer")]
	public uint PrimalMatrixRewardIdEngineer { get; set; }

	[Column("primalMatrixRewardIdEsper")]
	public uint PrimalMatrixRewardIdEsper { get; set; }

	[Column("primalMatrixRewardIdMedic")]
	public uint PrimalMatrixRewardIdMedic { get; set; }

	[Column("primalMatrixRewardIdStalker")]
	public uint PrimalMatrixRewardIdStalker { get; set; }

	[Column("primalMatrixRewardIdSpellslinger")]
	public uint PrimalMatrixRewardIdSpellslinger { get; set; }
}
