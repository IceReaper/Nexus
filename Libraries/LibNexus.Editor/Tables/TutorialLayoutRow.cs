using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TutorialLayoutRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("form")]
	public string Form { get; set; } = string.Empty;

	[Column("flags")]
	public uint Flags { get; set; }
}
