using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SalvageExceptionRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("item2Id")]
	public uint Item2Id { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }
}
