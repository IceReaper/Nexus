using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldWaterWakeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("colorTexture")]
	public string ColorTexture { get; set; } = string.Empty;

	[Column("normalTexture")]
	public string NormalTexture { get; set; } = string.Empty;

	[Column("distortionTexture")]
	public string DistortionTexture { get; set; } = string.Empty;

	[Column("durationMin")]
	public uint DurationMin { get; set; }

	[Column("durationMax")]
	public uint DurationMax { get; set; }

	[Column("scaleStart")]
	public float ScaleStart { get; set; }

	[Column("scaleEnd")]
	public float ScaleEnd { get; set; }

	[Column("alphaStart")]
	public float AlphaStart { get; set; }

	[Column("alphaEnd")]
	public float AlphaEnd { get; set; }

	[Column("distortionWeight")]
	public float DistortionWeight { get; set; }

	[Column("distortionScaleStart")]
	public float DistortionScaleStart { get; set; }

	[Column("distortionScaleEnd")]
	public float DistortionScaleEnd { get; set; }

	[Column("distortionSpeedU")]
	public float DistortionSpeedU { get; set; }

	[Column("distortionSpeedV")]
	public float DistortionSpeedV { get; set; }

	[Column("positionOffsetX")]
	public float PositionOffsetX { get; set; }

	[Column("positionOffsetY")]
	public float PositionOffsetY { get; set; }
}
