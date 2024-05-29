using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldLocation2Row
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("radius")]
	public float Radius { get; set; }

	[Column("maxVerticalDistance")]
	public float MaxVerticalDistance { get; set; }

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

	[Column("worldId")]
	public uint WorldId { get; set; }

	[Column("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[Column("phases")]
	public uint Phases { get; set; }
}
