using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class DatacubeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("datacubeTypeEnum")]
	public uint DatacubeTypeEnum { get; set; }

	[Column("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[Column("localizedTextIdText00")]
	public uint LocalizedTextIdText00 { get; set; }

	[Column("localizedTextIdText01")]
	public uint LocalizedTextIdText01 { get; set; }

	[Column("localizedTextIdText02")]
	public uint LocalizedTextIdText02 { get; set; }

	[Column("localizedTextIdText03")]
	public uint LocalizedTextIdText03 { get; set; }

	[Column("localizedTextIdText04")]
	public uint LocalizedTextIdText04 { get; set; }

	[Column("localizedTextIdText05")]
	public uint LocalizedTextIdText05 { get; set; }

	[Column("soundEventId")]
	public uint SoundEventId { get; set; }

	[Column("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[Column("unlockCount")]
	public uint UnlockCount { get; set; }

	[Column("assetPathImage")]
	public string AssetPathImage { get; set; } = string.Empty;

	[Column("datacubeFactionEnum")]
	public uint DatacubeFactionEnum { get; set; }

	[Column("worldLocation2Id")]
	public uint WorldLocation2Id { get; set; }

	[Column("questDirectionId")]
	public uint QuestDirectionId { get; set; }
}
