using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SoundParameterRow
{
	[Column("id")]
	public uint Id { get; set; }

	[Column("hash")]
	public uint Hash { get; set; }
}
