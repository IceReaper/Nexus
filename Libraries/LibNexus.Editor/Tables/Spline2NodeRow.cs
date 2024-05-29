using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spline2NodeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("splineId")]
	public uint SplineId { get; set; }

	[Column("ordinal")]
	public uint Ordinal { get; set; }

	[Column("position0")]
	public float Position0 { get; set; }

	[Column("position1")]
	public float Position1 { get; set; }

	[Column("position2")]
	public float Position2 { get; set; }

	[Column("facing0")]
	public float Facing0 { get; set; }

	[Column("facing1")]
	public float Facing1 { get; set; }

	[Column("facing2")]
	public float Facing2 { get; set; }

	[Column("facing3")]
	public float Facing3 { get; set; }

	[Column("eventId")]
	public uint EventId { get; set; }

	[Column("frameTime")]
	public float FrameTime { get; set; }

	[Column("delay")]
	public float Delay { get; set; }

	[Column("fovy")]
	public float Fovy { get; set; }
}
