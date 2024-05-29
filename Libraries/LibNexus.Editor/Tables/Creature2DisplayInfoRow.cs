using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Creature2DisplayInfoRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("statusFlags")]
	public uint StatusFlags { get; set; }

	[Column("assetPath")]
	public string AssetPath { get; set; } = string.Empty;

	[Column("assetTexture00")]
	public string AssetTexture00 { get; set; } = string.Empty;

	[Column("assetTexture01")]
	public string AssetTexture01 { get; set; } = string.Empty;

	[Column("assetTexture02")]
	public string AssetTexture02 { get; set; } = string.Empty;

	[Column("assetTexture03")]
	public string AssetTexture03 { get; set; } = string.Empty;

	[Column("assetTexture04")]
	public string AssetTexture04 { get; set; } = string.Empty;

	[Column("assetTexture05")]
	public string AssetTexture05 { get; set; } = string.Empty;

	[Column("modelTextureId00")]
	public uint ModelTextureId00 { get; set; }

	[Column("modelTextureId01")]
	public uint ModelTextureId01 { get; set; }

	[Column("modelTextureId02")]
	public uint ModelTextureId02 { get; set; }

	[Column("modelTextureId03")]
	public uint ModelTextureId03 { get; set; }

	[Column("modelTextureId04")]
	public uint ModelTextureId04 { get; set; }

	[Column("modelTextureId05")]
	public uint ModelTextureId05 { get; set; }

	[Column("colorShiftTexturePath")]
	public string ColorShiftTexturePath { get; set; } = string.Empty;

	[Column("colorShiftTextureIdMask")]
	public uint ColorShiftTextureIdMask { get; set; }

	[Column("materialDataIdSkinColor0")]
	public uint MaterialDataIdSkinColor0 { get; set; }

	[Column("materialDataIdSkinColor1")]
	public uint MaterialDataIdSkinColor1 { get; set; }

	[Column("materialDataIdWeaponColor0")]
	public uint MaterialDataIdWeaponColor0 { get; set; }

	[Column("materialDataIdWeaponColor1")]
	public uint MaterialDataIdWeaponColor1 { get; set; }

	[Column("materialDataIdArmorColor0")]
	public uint MaterialDataIdArmorColor0 { get; set; }

	[Column("materialDataIdArmorColor1")]
	public uint MaterialDataIdArmorColor1 { get; set; }

	[Column("materialDataIdDefault0")]
	public uint MaterialDataIdDefault0 { get; set; }

	[Column("materialDataIdDefault1")]
	public uint MaterialDataIdDefault1 { get; set; }

	[Column("creatureMaterialEnum")]
	public uint CreatureMaterialEnum { get; set; }

	[Column("scale")]
	public float Scale { get; set; }

	[Column("hitRadius")]
	public float HitRadius { get; set; }

	[Column("walkLand")]
	public float WalkLand { get; set; }

	[Column("walkAir")]
	public float WalkAir { get; set; }

	[Column("walkWater")]
	public float WalkWater { get; set; }

	[Column("walkHover")]
	public float WalkHover { get; set; }

	[Column("runLand")]
	public float RunLand { get; set; }

	[Column("runAir")]
	public float RunAir { get; set; }

	[Column("runWater")]
	public float RunWater { get; set; }

	[Column("runHover")]
	public float RunHover { get; set; }

	[Column("itemVisualTypeIdFeet")]
	public uint ItemVisualTypeIdFeet { get; set; }

	[Column("swimWaterDepth")]
	public float SwimWaterDepth { get; set; }

	[Column("raceId")]
	public uint RaceId { get; set; }

	[Column("sex")]
	public uint Sex { get; set; }

	[Column("itemDisplayId00")]
	public uint ItemDisplayId00 { get; set; }

	[Column("itemDisplayId01")]
	public uint ItemDisplayId01 { get; set; }

	[Column("itemDisplayId02")]
	public uint ItemDisplayId02 { get; set; }

	[Column("itemDisplayId03")]
	public uint ItemDisplayId03 { get; set; }

	[Column("itemDisplayId04")]
	public uint ItemDisplayId04 { get; set; }

	[Column("itemDisplayId05")]
	public uint ItemDisplayId05 { get; set; }

	[Column("itemDisplayId06")]
	public uint ItemDisplayId06 { get; set; }

	[Column("itemDisplayId07")]
	public uint ItemDisplayId07 { get; set; }

	[Column("itemDisplayId08")]
	public uint ItemDisplayId08 { get; set; }

	[Column("itemDisplayId09")]
	public uint ItemDisplayId09 { get; set; }

	[Column("itemDisplayId10")]
	public uint ItemDisplayId10 { get; set; }

	[Column("itemDisplayId11")]
	public uint ItemDisplayId11 { get; set; }

	[Column("itemDisplayId12")]
	public uint ItemDisplayId12 { get; set; }

	[Column("itemDisplayId13")]
	public uint ItemDisplayId13 { get; set; }

	[Column("itemDisplayId14")]
	public uint ItemDisplayId14 { get; set; }

	[Column("itemDisplayId15")]
	public uint ItemDisplayId15 { get; set; }

	[Column("itemDisplayId16")]
	public uint ItemDisplayId16 { get; set; }

	[Column("itemDisplayId17")]
	public uint ItemDisplayId17 { get; set; }

	[Column("itemDisplayId18")]
	public uint ItemDisplayId18 { get; set; }

	[Column("itemDisplayId19")]
	public uint ItemDisplayId19 { get; set; }

	[Column("modelMeshId00")]
	public uint ModelMeshId00 { get; set; }

	[Column("modelMeshId01")]
	public uint ModelMeshId01 { get; set; }

	[Column("modelMeshId02")]
	public uint ModelMeshId02 { get; set; }

	[Column("modelMeshId03")]
	public uint ModelMeshId03 { get; set; }

	[Column("modelMeshId04")]
	public uint ModelMeshId04 { get; set; }

	[Column("modelMeshId05")]
	public uint ModelMeshId05 { get; set; }

	[Column("modelMeshId06")]
	public uint ModelMeshId06 { get; set; }

	[Column("modelMeshId07")]
	public uint ModelMeshId07 { get; set; }

	[Column("modelMeshId08")]
	public uint ModelMeshId08 { get; set; }

	[Column("modelMeshId09")]
	public uint ModelMeshId09 { get; set; }

	[Column("modelMeshId10")]
	public uint ModelMeshId10 { get; set; }

	[Column("modelMeshId11")]
	public uint ModelMeshId11 { get; set; }

	[Column("modelMeshId12")]
	public uint ModelMeshId12 { get; set; }

	[Column("modelMeshId13")]
	public uint ModelMeshId13 { get; set; }

	[Column("modelMeshId14")]
	public uint ModelMeshId14 { get; set; }

	[Column("modelMeshId15")]
	public uint ModelMeshId15 { get; set; }

	[Column("groundOffsetHover")]
	public float GroundOffsetHover { get; set; }

	[Column("groundOffsetFly")]
	public float GroundOffsetFly { get; set; }
}
