using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ChallengeTierRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("count")]
	public uint Count { get; set; }
}
