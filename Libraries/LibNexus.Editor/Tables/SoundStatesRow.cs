using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SoundStatesRow
{
	[Column("id")]
	public uint Id { get; set; }

	[Column("nameHash")]
	public uint NameHash { get; set; }

	[Column("soundGroupHash")]
	public uint SoundGroupHash { get; set; }
}
