using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldSocketRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("worldId")]
	public uint WorldId { get; set; }

	[Column("bounds0")]
	public uint Bounds0 { get; set; }

	[Column("bounds1")]
	public uint Bounds1 { get; set; }

	[Column("bounds2")]
	public uint Bounds2 { get; set; }

	[Column("bounds3")]
	public uint Bounds3 { get; set; }

	[Column("averageHeight")]
	public uint AverageHeight { get; set; }
}
