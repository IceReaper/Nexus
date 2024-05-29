using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathSoldierEventWaveRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("pathSoldierEventId")]
	public uint PathSoldierEventId { get; set; }

	[Column("waveIndex")]
	public uint WaveIndex { get; set; }

	[Column("soundZoneKitId")]
	public uint SoundZoneKitId { get; set; }
}
