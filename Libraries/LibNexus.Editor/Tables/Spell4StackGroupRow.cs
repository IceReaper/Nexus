using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4StackGroupRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("stackCap")]
	public uint StackCap { get; set; }

	[Column("stackTypeEnum")]
	public uint StackTypeEnum { get; set; }
}
