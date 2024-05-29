using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WordFilterChinaRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("filter")]
	public string Filter { get; set; } = string.Empty;
}
