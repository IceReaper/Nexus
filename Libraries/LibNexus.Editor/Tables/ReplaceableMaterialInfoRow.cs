using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ReplaceableMaterialInfoRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("type")]
	public uint Type { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("op")]
	public uint Op { get; set; }

	[Column("blend")]
	public uint Blend { get; set; }

	[Column("shaderNum00")]
	public uint ShaderNum00 { get; set; }

	[Column("shaderNum01")]
	public uint ShaderNum01 { get; set; }

	[Column("numLayers")]
	public uint NumLayers { get; set; }

	[Column("colorIndex01")]
	public uint ColorIndex01 { get; set; }

	[Column("colorIndex00")]
	public uint ColorIndex00 { get; set; }

	[Column("colorIndex02")]
	public uint ColorIndex02 { get; set; }

	[Column("colorIndex03")]
	public uint ColorIndex03 { get; set; }

	[Column("normalIndex00")]
	public uint NormalIndex00 { get; set; }

	[Column("normalIndex01")]
	public uint NormalIndex01 { get; set; }

	[Column("normalIndex02")]
	public uint NormalIndex02 { get; set; }

	[Column("normalIndex03")]
	public uint NormalIndex03 { get; set; }

	[Column("heightSource00")]
	public uint HeightSource00 { get; set; }

	[Column("heightSource01")]
	public uint HeightSource01 { get; set; }

	[Column("heightSource02")]
	public uint HeightSource02 { get; set; }

	[Column("heightSource03")]
	public uint HeightSource03 { get; set; }

	[Column("opacitySource00")]
	public uint OpacitySource00 { get; set; }

	[Column("opacitySource01")]
	public uint OpacitySource01 { get; set; }

	[Column("opacitySource02")]
	public uint OpacitySource02 { get; set; }

	[Column("opacitySource03")]
	public uint OpacitySource03 { get; set; }

	[Column("glossSource00")]
	public uint GlossSource00 { get; set; }

	[Column("glossSource01")]
	public uint GlossSource01 { get; set; }

	[Column("glossSource02")]
	public uint GlossSource02 { get; set; }

	[Column("glossSource03")]
	public uint GlossSource03 { get; set; }

	[Column("glowSource00")]
	public uint GlowSource00 { get; set; }

	[Column("glowSource01")]
	public uint GlowSource01 { get; set; }

	[Column("glowSource02")]
	public uint GlowSource02 { get; set; }

	[Column("glowSource03")]
	public uint GlowSource03 { get; set; }

	[Column("shaderSource00")]
	public uint ShaderSource00 { get; set; }

	[Column("shaderSource01")]
	public uint ShaderSource01 { get; set; }

	[Column("shaderSource02")]
	public uint ShaderSource02 { get; set; }

	[Column("shaderSource03")]
	public uint ShaderSource03 { get; set; }

	[Column("heightValue00")]
	public float HeightValue00 { get; set; }

	[Column("heightValue01")]
	public float HeightValue01 { get; set; }

	[Column("heightValue02")]
	public float HeightValue02 { get; set; }

	[Column("heightValue03")]
	public float HeightValue03 { get; set; }

	[Column("opacityValue00")]
	public float OpacityValue00 { get; set; }

	[Column("opacityValue01")]
	public float OpacityValue01 { get; set; }

	[Column("opacityValue02")]
	public float OpacityValue02 { get; set; }

	[Column("opacityValue03")]
	public float OpacityValue03 { get; set; }

	[Column("glossValue00")]
	public float GlossValue00 { get; set; }

	[Column("glossValue01")]
	public float GlossValue01 { get; set; }

	[Column("glossValue02")]
	public float GlossValue02 { get; set; }

	[Column("glossValue03")]
	public float GlossValue03 { get; set; }

	[Column("glowValue00")]
	public float GlowValue00 { get; set; }

	[Column("glowValue01")]
	public float GlowValue01 { get; set; }

	[Column("glowValue02")]
	public float GlowValue02 { get; set; }

	[Column("glowValue03")]
	public float GlowValue03 { get; set; }

	[Column("shaderValue00")]
	public float ShaderValue00 { get; set; }

	[Column("shaderValue01")]
	public float ShaderValue01 { get; set; }

	[Column("shaderValue02")]
	public float ShaderValue02 { get; set; }

	[Column("shaderValue03")]
	public float ShaderValue03 { get; set; }

	[Column("heightScale00")]
	public float HeightScale00 { get; set; }

	[Column("heightScale01")]
	public float HeightScale01 { get; set; }

	[Column("heightScale02")]
	public float HeightScale02 { get; set; }

	[Column("heightScale03")]
	public float HeightScale03 { get; set; }

	[Column("heightOffset00")]
	public float HeightOffset00 { get; set; }

	[Column("heightOffset01")]
	public float HeightOffset01 { get; set; }

	[Column("heightOffset02")]
	public float HeightOffset02 { get; set; }

	[Column("heightOffset03")]
	public float HeightOffset03 { get; set; }

	[Column("parallaxScale00")]
	public float ParallaxScale00 { get; set; }

	[Column("parallaxScale01")]
	public float ParallaxScale01 { get; set; }

	[Column("parallaxScale02")]
	public float ParallaxScale02 { get; set; }

	[Column("parallaxScale03")]
	public float ParallaxScale03 { get; set; }

	[Column("parallaxOffset00")]
	public float ParallaxOffset00 { get; set; }

	[Column("parallaxOffset01")]
	public float ParallaxOffset01 { get; set; }

	[Column("parallaxOffset02")]
	public float ParallaxOffset02 { get; set; }

	[Column("parallaxOffset03")]
	public float ParallaxOffset03 { get; set; }

	[Column("textureTiles00")]
	public uint TextureTiles00 { get; set; }

	[Column("textureTiles01")]
	public uint TextureTiles01 { get; set; }

	[Column("textureTiles02")]
	public uint TextureTiles02 { get; set; }

	[Column("textureTiles03")]
	public uint TextureTiles03 { get; set; }

	[Column("colorModX00")]
	public float ColorModX00 { get; set; }

	[Column("colorModX01")]
	public float ColorModX01 { get; set; }

	[Column("colorModX02")]
	public float ColorModX02 { get; set; }

	[Column("colorModX03")]
	public float ColorModX03 { get; set; }

	[Column("colorModY00")]
	public float ColorModY00 { get; set; }

	[Column("colorModY01")]
	public float ColorModY01 { get; set; }

	[Column("colorModY02")]
	public float ColorModY02 { get; set; }

	[Column("colorModY03")]
	public float ColorModY03 { get; set; }

	[Column("colorModZ00")]
	public float ColorModZ00 { get; set; }

	[Column("colorModZ01")]
	public float ColorModZ01 { get; set; }

	[Column("colorModZ02")]
	public float ColorModZ02 { get; set; }

	[Column("colorModZ03")]
	public float ColorModZ03 { get; set; }

	[Column("materialTypeId00")]
	public uint MaterialTypeId00 { get; set; }

	[Column("materialTypeId01")]
	public uint MaterialTypeId01 { get; set; }

	[Column("materialTypeId02")]
	public uint MaterialTypeId02 { get; set; }

	[Column("materialTypeId03")]
	public uint MaterialTypeId03 { get; set; }

	[Column("colorTexture00")]
	public string ColorTexture00 { get; set; } = string.Empty;

	[Column("colorTexture01")]
	public string ColorTexture01 { get; set; } = string.Empty;

	[Column("colorTexture02")]
	public string ColorTexture02 { get; set; } = string.Empty;

	[Column("colorTexture03")]
	public string ColorTexture03 { get; set; } = string.Empty;

	[Column("normalTexture00")]
	public string NormalTexture00 { get; set; } = string.Empty;

	[Column("normalTexture01")]
	public string NormalTexture01 { get; set; } = string.Empty;

	[Column("normalTexture02")]
	public string NormalTexture02 { get; set; } = string.Empty;

	[Column("normalTexture03")]
	public string NormalTexture03 { get; set; } = string.Empty;
}
