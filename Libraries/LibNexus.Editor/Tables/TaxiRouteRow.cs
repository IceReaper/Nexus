using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TaxiRouteRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("taxiNodeIdSource")]
	public uint TaxiNodeIdSource { get; set; }

	[Column("taxiNodeIdDestination")]
	public uint TaxiNodeIdDestination { get; set; }

	[Column("price")]
	public uint Price { get; set; }
}
