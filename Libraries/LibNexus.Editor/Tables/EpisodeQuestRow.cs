using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class EpisodeQuestRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("episodeId")]
	public uint EpisodeId { get; set; }

	[Column("questId")]
	public uint QuestId { get; set; }

	[Column("orderIdx")]
	public uint OrderIdx { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }
}
