using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class BinkMovieRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("binkMovieAssetPath")]
	public string BinkMovieAssetPath { get; set; } = string.Empty;

	[Column("flags")]
	public uint Flags { get; set; }
}
