using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldZoneRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("parentZoneId")]
	public uint ParentZoneId { get; set; }

	[Column("allowAccess")]
	public bool AllowAccess { get; set; }

	[Column("color")]
	public uint Color { get; set; }

	[Column("soundZoneKitId")]
	public uint SoundZoneKitId { get; set; }

	[Column("worldLocation2IdExit")]
	public uint WorldLocation2IdExit { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("zonePvpRulesEnum")]
	public uint ZonePvpRulesEnum { get; set; }

	[Column("rewardRotationContentId")]
	public uint RewardRotationContentId { get; set; }
}
