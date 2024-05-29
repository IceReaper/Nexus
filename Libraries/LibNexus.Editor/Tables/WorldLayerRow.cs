using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldLayerRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("Description")]
	public string Description { get; set; } = string.Empty;

	[Column("HeightScale")]
	public float HeightScale { get; set; }

	[Column("HeightOffset")]
	public float HeightOffset { get; set; }

	[Column("ParallaxScale")]
	public float ParallaxScale { get; set; }

	[Column("ParallaxOffset")]
	public float ParallaxOffset { get; set; }

	[Column("MetersPerTextureTile")]
	public float MetersPerTextureTile { get; set; }

	[Column("ColorMapPath")]
	public string ColorMapPath { get; set; } = string.Empty;

	[Column("NormalMapPath")]
	public string NormalMapPath { get; set; } = string.Empty;

	[Column("AverageColor")]
	public uint AverageColor { get; set; }

	[Column("Projection")]
	public uint Projection { get; set; }

	[Column("materialType")]
	public uint MaterialType { get; set; }

	[Column("worldClutterId00")]
	public uint WorldClutterId00 { get; set; }

	[Column("worldClutterId01")]
	public uint WorldClutterId01 { get; set; }

	[Column("worldClutterId02")]
	public uint WorldClutterId02 { get; set; }

	[Column("worldClutterId03")]
	public uint WorldClutterId03 { get; set; }

	[Column("specularPower")]
	public float SpecularPower { get; set; }

	[Column("emissiveGlow")]
	public uint EmissiveGlow { get; set; }

	[Column("scrollSpeed00")]
	public float ScrollSpeed00 { get; set; }

	[Column("scrollSpeed01")]
	public float ScrollSpeed01 { get; set; }
}
