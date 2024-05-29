using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WindRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("type")]
	public uint Type { get; set; }

	[Column("duration")]
	public uint Duration { get; set; }

	[Column("radiusEnd")]
	public float RadiusEnd { get; set; }

	[Column("direction")]
	public float Direction { get; set; }

	[Column("directionDelta")]
	public float DirectionDelta { get; set; }

	[Column("blendIn")]
	public float BlendIn { get; set; }

	[Column("blendOut")]
	public float BlendOut { get; set; }

	[Column("speed")]
	public float Speed { get; set; }

	[Column("sine2DMagnitudeMin")]
	public float Sine2DMagnitudeMin { get; set; }

	[Column("sine2DMagnitudeMax")]
	public float Sine2DMagnitudeMax { get; set; }

	[Column("sine2DFrequency")]
	public float Sine2DFrequency { get; set; }

	[Column("sine2DOffsetAngle")]
	public float Sine2DOffsetAngle { get; set; }

	[Column("localRadial")]
	public uint LocalRadial { get; set; }

	[Column("localMagnitude")]
	public float LocalMagnitude { get; set; }
}
