using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4PrerequisitesRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }
}
