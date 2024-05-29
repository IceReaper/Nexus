using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillCatalystOrderingRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("unlockLevel00")]
	public uint UnlockLevel00 { get; set; }

	[Column("unlockLevel01")]
	public uint UnlockLevel01 { get; set; }

	[Column("unlockLevel02")]
	public uint UnlockLevel02 { get; set; }

	[Column("unlockLevel03")]
	public uint UnlockLevel03 { get; set; }

	[Column("unlockLevel04")]
	public uint UnlockLevel04 { get; set; }
}
