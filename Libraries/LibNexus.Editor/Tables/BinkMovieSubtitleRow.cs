using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class BinkMovieSubtitleRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("binkMovieId")]
	public uint BinkMovieId { get; set; }

	[Column("delayMs")]
	public uint DelayMs { get; set; }

	[Column("localizedTextIdDisplayText")]
	public uint LocalizedTextIdDisplayText { get; set; }
}
