using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spline2Row
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("worldId")]
	public uint WorldId { get; set; }

	[Column("splineType")]
	public uint SplineType { get; set; }
}
