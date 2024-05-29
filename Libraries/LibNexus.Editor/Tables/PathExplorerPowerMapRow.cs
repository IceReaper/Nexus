using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathExplorerPowerMapRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("distanceThreshold")]
	public uint DistanceThreshold { get; set; }

	[Column("collectQuantity")]
	public uint CollectQuantity { get; set; }

	[Column("victoryPauseMS")]
	public uint VictoryPauseMs { get; set; }

	[Column("worldLocation2IdVisual")]
	public uint WorldLocation2IdVisual { get; set; }

	[Column("visualEffectIdInactive")]
	public uint VisualEffectIdInactive { get; set; }

	[Column("localizedTextIdInfo")]
	public uint LocalizedTextIdInfo { get; set; }
}
