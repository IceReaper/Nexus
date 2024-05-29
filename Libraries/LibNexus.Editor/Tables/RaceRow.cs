using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RaceRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("enumName")]
	public string EnumName { get; set; } = string.Empty;

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("localizedTextIdNameFemale")]
	public uint LocalizedTextIdNameFemale { get; set; }

	[Column("maleAssetPath")]
	public string MaleAssetPath { get; set; } = string.Empty;

	[Column("femaleAssetPath")]
	public string FemaleAssetPath { get; set; } = string.Empty;

	[Column("hitRadius")]
	public float HitRadius { get; set; }

	[Column("soundImpactDescriptionIdOrigin")]
	public uint SoundImpactDescriptionIdOrigin { get; set; }

	[Column("soundImpactDescriptionIdTarget")]
	public uint SoundImpactDescriptionIdTarget { get; set; }

	[Column("walkLand")]
	public float WalkLand { get; set; }

	[Column("walkAir")]
	public float WalkAir { get; set; }

	[Column("walkWater")]
	public float WalkWater { get; set; }

	[Column("walkHover")]
	public float WalkHover { get; set; }

	[Column("unitVisualTypeIdMale")]
	public uint UnitVisualTypeIdMale { get; set; }

	[Column("unitVisualTypeIdFemale")]
	public uint UnitVisualTypeIdFemale { get; set; }

	[Column("soundEventIdMaleHealthStart")]
	public uint SoundEventIdMaleHealthStart { get; set; }

	[Column("soundEventIdFemaleHealthStart")]
	public uint SoundEventIdFemaleHealthStart { get; set; }

	[Column("soundEventIdMaleHealthStop")]
	public uint SoundEventIdMaleHealthStop { get; set; }

	[Column("soundEventIdFemaleHealthStop")]
	public uint SoundEventIdFemaleHealthStop { get; set; }

	[Column("swimWaterDepth")]
	public float SwimWaterDepth { get; set; }

	[Column("itemDisplayIdUnderwearLegsMale")]
	public uint ItemDisplayIdUnderwearLegsMale { get; set; }

	[Column("itemDisplayIdUnderwearLegsFemale")]
	public uint ItemDisplayIdUnderwearLegsFemale { get; set; }

	[Column("itemDisplayIdUnderwearChestFemale")]
	public uint ItemDisplayIdUnderwearChestFemale { get; set; }

	[Column("itemDisplayIdArmCannon")]
	public uint ItemDisplayIdArmCannon { get; set; }

	[Column("mountScaleMale")]
	public float MountScaleMale { get; set; }

	[Column("mountScaleFemale")]
	public float MountScaleFemale { get; set; }

	[Column("soundSwitchId")]
	public uint SoundSwitchId { get; set; }

	[Column("componentLayoutIdMale")]
	public uint ComponentLayoutIdMale { get; set; }

	[Column("componentLayoutIdFemale")]
	public uint ComponentLayoutIdFemale { get; set; }

	[Column("modelMeshIdMountItemMale")]
	public uint ModelMeshIdMountItemMale { get; set; }

	[Column("modelMeshIdMountItemFemale")]
	public uint ModelMeshIdMountItemFemale { get; set; }
}
