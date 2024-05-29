using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldWaterLayerRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("description")]
	public string Description { get; set; } = string.Empty;

	[Column("RippleColorTex")]
	public string RippleColorTex { get; set; } = string.Empty;

	[Column("RippleNormalTex")]
	public string RippleNormalTex { get; set; } = string.Empty;

	[Column("Scale")]
	public float Scale { get; set; }

	[Column("Rotation")]
	public float Rotation { get; set; }

	[Column("Speed")]
	public float Speed { get; set; }

	[Column("OscFrequency")]
	public float OscFrequency { get; set; }

	[Column("OscMagnitude")]
	public float OscMagnitude { get; set; }

	[Column("OscRotation")]
	public float OscRotation { get; set; }

	[Column("OscPhase")]
	public float OscPhase { get; set; }

	[Column("OscMinLayerWeight")]
	public float OscMinLayerWeight { get; set; }

	[Column("OscMaxLayerWeight")]
	public float OscMaxLayerWeight { get; set; }

	[Column("OscLayerWeightPhase")]
	public float OscLayerWeightPhase { get; set; }

	[Column("materialBlend")]
	public float MaterialBlend { get; set; }
}
