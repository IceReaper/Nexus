using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathLevelRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("pathTypeEnum")]
	public uint PathTypeEnum { get; set; }

	[Column("pathLevel")]
	public uint PathLevel { get; set; }

	[Column("pathXP")]
	public uint PathXp { get; set; }
}
