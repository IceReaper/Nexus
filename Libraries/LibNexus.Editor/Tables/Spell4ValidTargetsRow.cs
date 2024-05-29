using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4ValidTargetsRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("targetBitmask")]
	public uint TargetBitmask { get; set; }
}
