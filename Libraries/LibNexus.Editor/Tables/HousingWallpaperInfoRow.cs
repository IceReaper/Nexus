using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingWallpaperInfoRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("cost")]
	public uint Cost { get; set; }

	[Column("costCurrencyTypeId")]
	public uint CostCurrencyTypeId { get; set; }

	[Column("replaceableMaterialInfoId")]
	public uint ReplaceableMaterialInfoId { get; set; }

	[Column("worldSkyId")]
	public uint WorldSkyId { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("prerequisiteIdUnlock")]
	public uint PrerequisiteIdUnlock { get; set; }

	[Column("prerequisiteIdUse")]
	public uint PrerequisiteIdUse { get; set; }

	[Column("unlockIndex")]
	public uint UnlockIndex { get; set; }

	[Column("soundZoneKitId")]
	public uint SoundZoneKitId { get; set; }

	[Column("worldLayerId00")]
	public uint WorldLayerId00 { get; set; }

	[Column("worldLayerId01")]
	public uint WorldLayerId01 { get; set; }

	[Column("worldLayerId02")]
	public uint WorldLayerId02 { get; set; }

	[Column("worldLayerId03")]
	public uint WorldLayerId03 { get; set; }

	[Column("accountItemIdUpsell")]
	public uint AccountItemIdUpsell { get; set; }
}
