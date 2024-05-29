using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WindSpawnRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("intervalMin")]
	public uint IntervalMin { get; set; }

	[Column("intervalMax")]
	public uint IntervalMax { get; set; }

	[Column("directionMin")]
	public float DirectionMin { get; set; }

	[Column("directionMax")]
	public float DirectionMax { get; set; }
}
