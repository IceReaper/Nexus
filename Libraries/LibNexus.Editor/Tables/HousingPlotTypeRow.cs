using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingPlotTypeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("maxPlacedDecor")]
	public uint MaxPlacedDecor { get; set; }
}
