using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingDecorInfoRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("housingDecorTypeId")]
	public uint HousingDecorTypeId { get; set; }

	[Column("hookTypeId")]
	public uint HookTypeId { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("hookAssetId")]
	public uint HookAssetId { get; set; }

	[Column("cost")]
	public uint Cost { get; set; }

	[Column("costCurrencyTypeId")]
	public uint CostCurrencyTypeId { get; set; }

	[Column("creature2IdActiveProp")]
	public uint Creature2IdActiveProp { get; set; }

	[Column("prerequisiteIdUnlock")]
	public uint PrerequisiteIdUnlock { get; set; }

	[Column("spell4IdInteriorBuff")]
	public uint Spell4IdInteriorBuff { get; set; }

	[Column("housingDecorLimitCategoryId")]
	public uint HousingDecorLimitCategoryId { get; set; }

	[Column("altPreviewAsset")]
	public string AltPreviewAsset { get; set; } = string.Empty;

	[Column("altEditAsset")]
	public string AltEditAsset { get; set; } = string.Empty;

	[Column("minScale")]
	public float MinScale { get; set; }

	[Column("maxScale")]
	public float MaxScale { get; set; }
}
