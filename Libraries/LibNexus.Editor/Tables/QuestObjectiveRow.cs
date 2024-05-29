using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class QuestObjectiveRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("type")]
	public uint Type { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("data")]
	public uint Data { get; set; }

	[Column("count")]
	public uint Count { get; set; }

	[Column("localizedTextIdFull")]
	public uint LocalizedTextIdFull { get; set; }

	[Column("worldLocationsIdIndicator00")]
	public uint WorldLocationsIdIndicator00 { get; set; }

	[Column("worldLocationsIdIndicator01")]
	public uint WorldLocationsIdIndicator01 { get; set; }

	[Column("worldLocationsIdIndicator02")]
	public uint WorldLocationsIdIndicator02 { get; set; }

	[Column("worldLocationsIdIndicator03")]
	public uint WorldLocationsIdIndicator03 { get; set; }

	[Column("maxTimeAllowedMS")]
	public uint MaxTimeAllowedMs { get; set; }

	[Column("localizedTextIdShort")]
	public uint LocalizedTextIdShort { get; set; }

	[Column("targetGroupIdRewardPane")]
	public uint TargetGroupIdRewardPane { get; set; }

	[Column("questDirectionId")]
	public uint QuestDirectionId { get; set; }
}
