using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4TagRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }
}
