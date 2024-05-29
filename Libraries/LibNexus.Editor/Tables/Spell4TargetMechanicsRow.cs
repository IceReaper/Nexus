using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4TargetMechanicsRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("targetType")]
	public uint TargetType { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }
}
