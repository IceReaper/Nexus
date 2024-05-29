using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class GenericUnlockSetRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("genericUnlockScopeEnum")]
	public uint GenericUnlockScopeEnum { get; set; }

	[Column("genericUnlockEntryId00")]
	public uint GenericUnlockEntryId00 { get; set; }

	[Column("genericUnlockEntryId01")]
	public uint GenericUnlockEntryId01 { get; set; }

	[Column("genericUnlockEntryId02")]
	public uint GenericUnlockEntryId02 { get; set; }

	[Column("genericUnlockEntryId03")]
	public uint GenericUnlockEntryId03 { get; set; }

	[Column("genericUnlockEntryId04")]
	public uint GenericUnlockEntryId04 { get; set; }

	[Column("genericUnlockEntryId05")]
	public uint GenericUnlockEntryId05 { get; set; }
}
