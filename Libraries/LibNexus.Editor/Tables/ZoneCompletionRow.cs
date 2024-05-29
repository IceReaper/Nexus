using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ZoneCompletionRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("mapZoneId")]
	public uint MapZoneId { get; set; }

	[Column("zoneCompletionFactionEnum")]
	public uint ZoneCompletionFactionEnum { get; set; }

	[Column("episodeQuestCount")]
	public uint EpisodeQuestCount { get; set; }

	[Column("taskQuestCount")]
	public uint TaskQuestCount { get; set; }

	[Column("challengeCount")]
	public uint ChallengeCount { get; set; }

	[Column("datacubeCount")]
	public uint DatacubeCount { get; set; }

	[Column("taleCount")]
	public uint TaleCount { get; set; }

	[Column("journalCount")]
	public uint JournalCount { get; set; }

	[Column("characterTitleIdReward")]
	public uint CharacterTitleIdReward { get; set; }
}
