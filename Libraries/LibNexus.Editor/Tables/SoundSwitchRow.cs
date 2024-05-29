using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SoundSwitchRow
{
	[Column("id")]
	public uint Id { get; set; }

	[Column("nameHash")]
	public uint NameHash { get; set; }

	[Column("groupHash")]
	public uint GroupHash { get; set; }
}
