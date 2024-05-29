using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathScientistExperimentationRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("numAttempts")]
	public uint NumAttempts { get; set; }
}
