using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingPlotInfoRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("worldSocketId")]
	public uint WorldSocketId { get; set; }

	[Column("plotType")]
	public uint PlotType { get; set; }

	[Column("housingPropertyInfoId")]
	public uint HousingPropertyInfoId { get; set; }

	[Column("housingPropertyPlotIndex")]
	public uint HousingPropertyPlotIndex { get; set; }

	[Column("housingPlugItemIdDefault")]
	public uint HousingPlugItemIdDefault { get; set; }
}
