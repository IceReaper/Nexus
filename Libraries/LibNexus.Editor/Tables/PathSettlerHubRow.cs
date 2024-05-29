using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathSettlerHubRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("maxAvenueEconomy")]
	public uint MaxAvenueEconomy { get; set; }

	[Column("maxAvenueSecurity")]
	public uint MaxAvenueSecurity { get; set; }

	[Column("maxAvenueQualityOfLife")]
	public uint MaxAvenueQualityOfLife { get; set; }

	[Column("localizedTextIdEconomy")]
	public uint LocalizedTextIdEconomy { get; set; }

	[Column("localizedTextIdSecurity")]
	public uint LocalizedTextIdSecurity { get; set; }

	[Column("localizedTextIdQualityOfLife")]
	public uint LocalizedTextIdQualityOfLife { get; set; }

	[Column("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[Column("missionCount")]
	public uint MissionCount { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("item2IdResource00")]
	public uint Item2IdResource00 { get; set; }

	[Column("item2IdResource01")]
	public uint Item2IdResource01 { get; set; }

	[Column("item2IdResource02")]
	public uint Item2IdResource02 { get; set; }

	[Column("publicEventObjectiveIdResource00")]
	public uint PublicEventObjectiveIdResource00 { get; set; }

	[Column("publicEventObjectiveIdResource01")]
	public uint PublicEventObjectiveIdResource01 { get; set; }

	[Column("publicEventObjectiveIdResource02")]
	public uint PublicEventObjectiveIdResource02 { get; set; }

	[Column("worldLocation2IdMapResource00Loc00")]
	public uint WorldLocation2IdMapResource00Loc00 { get; set; }

	[Column("worldLocation2IdMapResource00Loc01")]
	public uint WorldLocation2IdMapResource00Loc01 { get; set; }

	[Column("worldLocation2IdMapResource00Loc02")]
	public uint WorldLocation2IdMapResource00Loc02 { get; set; }

	[Column("worldLocation2IdMapResource00Loc03")]
	public uint WorldLocation2IdMapResource00Loc03 { get; set; }

	[Column("worldLocation2IdMapResource01Loc00")]
	public uint WorldLocation2IdMapResource01Loc00 { get; set; }

	[Column("worldLocation2IdMapResource01Loc01")]
	public uint WorldLocation2IdMapResource01Loc01 { get; set; }

	[Column("worldLocation2IdMapResource01Loc02")]
	public uint WorldLocation2IdMapResource01Loc02 { get; set; }

	[Column("worldLocation2IdMapResource01Loc03")]
	public uint WorldLocation2IdMapResource01Loc03 { get; set; }

	[Column("worldLocation2IdMapResource02Loc00")]
	public uint WorldLocation2IdMapResource02Loc00 { get; set; }

	[Column("worldLocation2IdMapResource02Loc01")]
	public uint WorldLocation2IdMapResource02Loc01 { get; set; }

	[Column("worldLocation2IdMapResource02Loc02")]
	public uint WorldLocation2IdMapResource02Loc02 { get; set; }

	[Column("worldLocation2IdMapResource02Loc03")]
	public uint WorldLocation2IdMapResource02Loc03 { get; set; }

	[Column("localizedTextIdRewardNotify")]
	public uint LocalizedTextIdRewardNotify { get; set; }
}
