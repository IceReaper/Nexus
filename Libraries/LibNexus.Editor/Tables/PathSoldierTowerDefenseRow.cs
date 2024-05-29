using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathSoldierTowerDefenseRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("pathSoldierEventId")]
	public uint PathSoldierEventId { get; set; }

	[Column("buildCost")]
	public uint BuildCost { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("worldLocation2IdDisplay")]
	public uint WorldLocation2IdDisplay { get; set; }

	[Column("towerDefenseBuildType")]
	public uint TowerDefenseBuildType { get; set; }

	[Column("spell4Id")]
	public uint Spell4Id { get; set; }

	[Column("soldierTowerDefenseFlags")]
	public uint SoldierTowerDefenseFlags { get; set; }

	[Column("soldierTowerDefenseImprovementType")]
	public uint SoldierTowerDefenseImprovementType { get; set; }
}
