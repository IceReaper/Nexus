using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HookAssetRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("asset")]
	public string Asset { get; set; } = string.Empty;

	[Column("scale")]
	public float Scale { get; set; }

	[Column("offsetX")]
	public float OffsetX { get; set; }

	[Column("offsetY")]
	public float OffsetY { get; set; }

	[Column("offsetZ")]
	public float OffsetZ { get; set; }

	[Column("rotationX")]
	public float RotationX { get; set; }

	[Column("rotationY")]
	public float RotationY { get; set; }

	[Column("rotationZ")]
	public float RotationZ { get; set; }
}
