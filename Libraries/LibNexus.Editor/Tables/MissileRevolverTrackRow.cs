using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MissileRevolverTrackRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("radius")]
	public float Radius { get; set; }

	[Column("speed")]
	public float Speed { get; set; }

	[Column("speedMultiplier")]
	public float SpeedMultiplier { get; set; }

	[Column("scaleMultiplier")]
	public float ScaleMultiplier { get; set; }

	[Column("modelAttachmentIdHeight")]
	public uint ModelAttachmentIdHeight { get; set; }
}
