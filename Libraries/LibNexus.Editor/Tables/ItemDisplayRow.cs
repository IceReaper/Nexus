using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemDisplayRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("description")]
	public string Description { get; set; } = string.Empty;

	[Column("item2TypeId")]
	public uint Item2TypeId { get; set; }

	[Column("objectModel")]
	public string ObjectModel { get; set; } = string.Empty;

	[Column("objectModelL")]
	public string ObjectModelL { get; set; } = string.Empty;

	[Column("objectTexture0")]
	public string ObjectTexture0 { get; set; } = string.Empty;

	[Column("objectTexture1")]
	public string ObjectTexture1 { get; set; } = string.Empty;

	[Column("modelTextureIdObject00")]
	public uint ModelTextureIdObject00 { get; set; }

	[Column("modelTextureIdObject01")]
	public uint ModelTextureIdObject01 { get; set; }

	[Column("skinnedModel")]
	public string SkinnedModel { get; set; } = string.Empty;

	[Column("skinnedModelL")]
	public string SkinnedModelL { get; set; } = string.Empty;

	[Column("skinnedTexture0")]
	public string SkinnedTexture0 { get; set; } = string.Empty;

	[Column("skinnedTexture1")]
	public string SkinnedTexture1 { get; set; } = string.Empty;

	[Column("modelTextureIdSkinned00")]
	public uint ModelTextureIdSkinned00 { get; set; }

	[Column("modelTextureIdSkinned01")]
	public uint ModelTextureIdSkinned01 { get; set; }

	[Column("attachedModel")]
	public string AttachedModel { get; set; } = string.Empty;

	[Column("modelAttachmentIdAttached")]
	public uint ModelAttachmentIdAttached { get; set; }

	[Column("attachedTexture0")]
	public string AttachedTexture0 { get; set; } = string.Empty;

	[Column("attachedTexture1")]
	public string AttachedTexture1 { get; set; } = string.Empty;

	[Column("modelTextureIdAttached00")]
	public uint ModelTextureIdAttached00 { get; set; }

	[Column("modelTextureIdAttached01")]
	public uint ModelTextureIdAttached01 { get; set; }

	[Column("componentRegionFlags")]
	public uint ComponentRegionFlags { get; set; }

	[Column("componentPriority")]
	public uint ComponentPriority { get; set; }

	[Column("skinMaskMap")]
	public string SkinMaskMap { get; set; } = string.Empty;

	[Column("skinColorMap")]
	public string SkinColorMap { get; set; } = string.Empty;

	[Column("skinNormalMap")]
	public string SkinNormalMap { get; set; } = string.Empty;

	[Column("skinDyeMap")]
	public string SkinDyeMap { get; set; } = string.Empty;

	[Column("armorMaskMap")]
	public string ArmorMaskMap { get; set; } = string.Empty;

	[Column("armorColorMap")]
	public string ArmorColorMap { get; set; } = string.Empty;

	[Column("armorNormalMap")]
	public string ArmorNormalMap { get; set; } = string.Empty;

	[Column("armorDyeMap")]
	public string ArmorDyeMap { get; set; } = string.Empty;

	[Column("modelMeshId00")]
	public uint ModelMeshId00 { get; set; }

	[Column("modelMeshId01")]
	public uint ModelMeshId01 { get; set; }

	[Column("modelMeshId02")]
	public uint ModelMeshId02 { get; set; }

	[Column("modelMeshId03")]
	public uint ModelMeshId03 { get; set; }

	[Column("soundImpactDescriptionId")]
	public uint SoundImpactDescriptionId { get; set; }

	[Column("ItemVisualTypeId")]
	public uint ItemVisualTypeId { get; set; }

	[Column("soundReplaceDescriptionId")]
	public uint SoundReplaceDescriptionId { get; set; }

	[Column("itemColorSetId")]
	public uint ItemColorSetId { get; set; }

	[Column("dyeChannelFlags")]
	public uint DyeChannelFlags { get; set; }

	[Column("modelPoseId")]
	public uint ModelPoseId { get; set; }

	[Column("modelPoseBlend")]
	public float ModelPoseBlend { get; set; }

	[Column("shaderPreset00")]
	public uint ShaderPreset00 { get; set; }

	[Column("shaderPreset01")]
	public uint ShaderPreset01 { get; set; }
}
