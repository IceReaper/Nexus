using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathExplorerAreaRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("pathSettlerHubId")]
	public uint PathSettlerHubId { get; set; }
}
