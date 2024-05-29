using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4CcConditionsRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("ccStateMask")]
	public uint CcStateMask { get; set; }

	[Column("ccStateFlagsRequired")]
	public uint CcStateFlagsRequired { get; set; }
}
