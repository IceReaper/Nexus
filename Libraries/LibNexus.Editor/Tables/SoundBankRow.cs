using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SoundBankRow
{
	[Column("id")]
	public uint Id { get; set; }

	[Column("name")]
	public string Name { get; set; } = string.Empty;
}
