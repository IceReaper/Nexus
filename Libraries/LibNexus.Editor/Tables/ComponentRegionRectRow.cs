using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ComponentRegionRectRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("regionId")]
	public uint RegionId { get; set; }

	[Column("rectMinX")]
	public uint RectMinX { get; set; }

	[Column("rectMinY")]
	public uint RectMinY { get; set; }

	[Column("rectLimX")]
	public uint RectLimX { get; set; }

	[Column("rectLimY")]
	public uint RectLimY { get; set; }

	[Column("componentLayoutId")]
	public uint ComponentLayoutId { get; set; }
}
