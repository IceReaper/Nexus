using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TaxiNodeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("taxiNodeTypeEnum")]
	public uint TaxiNodeTypeEnum { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("flightPathTypeEnum")]
	public uint FlightPathTypeEnum { get; set; }

	[Column("taxiNodeFactionEnum")]
	public uint TaxiNodeFactionEnum { get; set; }

	[Column("worldLocation2Id")]
	public uint WorldLocation2Id { get; set; }

	[Column("contentTier")]
	public uint ContentTier { get; set; }

	[Column("autoUnlockLevel")]
	public uint AutoUnlockLevel { get; set; }

	[Column("recommendedMinLevel")]
	public uint RecommendedMinLevel { get; set; }

	[Column("recommendedMaxLevel")]
	public uint RecommendedMaxLevel { get; set; }
}
