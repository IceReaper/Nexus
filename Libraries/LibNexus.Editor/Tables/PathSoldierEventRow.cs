using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathSoldierEventRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("pathSoldierEventType")]
	public uint PathSoldierEventType { get; set; }

	[Column("maxTimeBetweenWaves")]
	public uint MaxTimeBetweenWaves { get; set; }

	[Column("maxEventTime")]
	public uint MaxEventTime { get; set; }

	[Column("towerDefenseAllowance")]
	public uint TowerDefenseAllowance { get; set; }

	[Column("towerDefenseBuildTimeMS")]
	public uint TowerDefenseBuildTimeMs { get; set; }

	[Column("initialSpawnTime")]
	public uint InitialSpawnTime { get; set; }
}
