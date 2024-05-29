using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathRewardRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("pathRewardTypeEnum")]
	public uint PathRewardTypeEnum { get; set; }

	[Column("objectId")]
	public uint ObjectId { get; set; }

	[Column("spell4Id")]
	public uint Spell4Id { get; set; }

	[Column("item2Id")]
	public uint Item2Id { get; set; }

	[Column("quest2Id")]
	public uint Quest2Id { get; set; }

	[Column("characterTitleId")]
	public uint CharacterTitleId { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[Column("count")]
	public uint Count { get; set; }

	[Column("pathRewardFlags")]
	public uint PathRewardFlags { get; set; }

	[Column("pathScientistScanBotProfileId")]
	public uint PathScientistScanBotProfileId { get; set; }
}
