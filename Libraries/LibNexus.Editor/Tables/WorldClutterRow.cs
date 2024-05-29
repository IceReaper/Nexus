using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldClutterRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("Description")]
	public string Description { get; set; } = string.Empty;

	[Column("density")]
	public float Density { get; set; }

	[Column("clutterFlags")]
	public uint ClutterFlags { get; set; }

	[Column("assetPath0")]
	public string AssetPath0 { get; set; } = string.Empty;

	[Column("assetPath01")]
	public string AssetPath01 { get; set; } = string.Empty;

	[Column("assetPath02")]
	public string AssetPath02 { get; set; } = string.Empty;

	[Column("assetPath03")]
	public string AssetPath03 { get; set; } = string.Empty;

	[Column("assetPath04")]
	public string AssetPath04 { get; set; } = string.Empty;

	[Column("assetPath05")]
	public string AssetPath05 { get; set; } = string.Empty;

	[Column("assetWeight0")]
	public float AssetWeight0 { get; set; }

	[Column("assetWeight01")]
	public float AssetWeight01 { get; set; }

	[Column("assetWeight02")]
	public float AssetWeight02 { get; set; }

	[Column("assetWeight03")]
	public float AssetWeight03 { get; set; }

	[Column("assetWeight04")]
	public float AssetWeight04 { get; set; }

	[Column("assetWeight05")]
	public float AssetWeight05 { get; set; }

	[Column("flag0")]
	public uint Flag0 { get; set; }

	[Column("flag01")]
	public uint Flag01 { get; set; }

	[Column("flag02")]
	public uint Flag02 { get; set; }

	[Column("flag03")]
	public uint Flag03 { get; set; }

	[Column("flag04")]
	public uint Flag04 { get; set; }

	[Column("flag05")]
	public uint Flag05 { get; set; }

	[Column("minScale0")]
	public float MinScale0 { get; set; }

	[Column("minScale01")]
	public float MinScale01 { get; set; }

	[Column("minScale02")]
	public float MinScale02 { get; set; }

	[Column("minScale03")]
	public float MinScale03 { get; set; }

	[Column("minScale04")]
	public float MinScale04 { get; set; }

	[Column("minScale05")]
	public float MinScale05 { get; set; }

	[Column("rotationMin0")]
	public float RotationMin0 { get; set; }

	[Column("rotationMin01")]
	public float RotationMin01 { get; set; }

	[Column("rotationMin02")]
	public float RotationMin02 { get; set; }

	[Column("rotationMin03")]
	public float RotationMin03 { get; set; }

	[Column("rotationMin04")]
	public float RotationMin04 { get; set; }

	[Column("rotationMin05")]
	public float RotationMin05 { get; set; }

	[Column("rotationMax0")]
	public float RotationMax0 { get; set; }

	[Column("rotationMax01")]
	public float RotationMax01 { get; set; }

	[Column("rotationMax02")]
	public float RotationMax02 { get; set; }

	[Column("rotationMax03")]
	public float RotationMax03 { get; set; }

	[Column("rotationMax04")]
	public float RotationMax04 { get; set; }

	[Column("rotationMax05")]
	public float RotationMax05 { get; set; }

	[Column("emissiveGlow00")]
	public uint EmissiveGlow00 { get; set; }

	[Column("emissiveGlow01")]
	public uint EmissiveGlow01 { get; set; }

	[Column("emissiveGlow02")]
	public uint EmissiveGlow02 { get; set; }

	[Column("emissiveGlow03")]
	public uint EmissiveGlow03 { get; set; }

	[Column("emissiveGlow04")]
	public uint EmissiveGlow04 { get; set; }

	[Column("emissiveGlow05")]
	public uint EmissiveGlow05 { get; set; }
}
