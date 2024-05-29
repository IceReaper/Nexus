using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PeriodicQuestSetRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("periodicQuestSetCategoryId")]
	public uint PeriodicQuestSetCategoryId { get; set; }

	[Column("periodicGroupsOffered")]
	public uint PeriodicGroupsOffered { get; set; }

	[Column("weight")]
	public uint Weight { get; set; }
}
