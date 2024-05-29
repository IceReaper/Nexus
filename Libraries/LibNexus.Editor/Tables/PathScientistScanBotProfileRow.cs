using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathScientistScanBotProfileRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("creature2Id")]
	public uint Creature2Id { get; set; }

	[Column("scanTimeMS")]
	public uint ScanTimeMs { get; set; }

	[Column("processingTimeMS")]
	public uint ProcessingTimeMs { get; set; }

	[Column("playerRadius")]
	public float PlayerRadius { get; set; }

	[Column("scanAOERange")]
	public float ScanAoeRange { get; set; }

	[Column("maxSeekDistance")]
	public float MaxSeekDistance { get; set; }

	[Column("speedMultiplier")]
	public float SpeedMultiplier { get; set; }

	[Column("thoroughnessMultiplier")]
	public float ThoroughnessMultiplier { get; set; }

	[Column("healthMultiplier")]
	public float HealthMultiplier { get; set; }

	[Column("healthRegenMultiplier")]
	public float HealthRegenMultiplier { get; set; }

	[Column("minCooldownTimeMs")]
	public uint MinCooldownTimeMs { get; set; }

	[Column("maxCooldownTimeMs")]
	public uint MaxCooldownTimeMs { get; set; }

	[Column("maxCooldownDistance")]
	public float MaxCooldownDistance { get; set; }

	[Column("pathScientistScanBotProfileFlags")]
	public uint PathScientistScanBotProfileFlags { get; set; }

	[Column("socketCount")]
	public uint SocketCount { get; set; }
}
