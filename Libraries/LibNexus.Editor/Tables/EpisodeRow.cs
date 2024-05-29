using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class EpisodeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdBriefing")]
	public uint LocalizedTextIdBriefing { get; set; }

	[Column("localizedTextIdEndSummary")]
	public uint LocalizedTextIdEndSummary { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[Column("percentToDisplay")]
	public uint PercentToDisplay { get; set; }

	[Column("questHubIdExile")]
	public uint QuestHubIdExile { get; set; }

	[Column("questHubIdDominion")]
	public uint QuestHubIdDominion { get; set; }
}
