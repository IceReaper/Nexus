using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class EmoteSequenceTransitionRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("emotesIdTo")]
	public uint EmotesIdTo { get; set; }

	[Column("standStateFrom")]
	public uint StandStateFrom { get; set; }

	[Column("emotesIdFrom")]
	public uint EmotesIdFrom { get; set; }

	[Column("modelSequenceId")]
	public uint ModelSequenceId { get; set; }
}
