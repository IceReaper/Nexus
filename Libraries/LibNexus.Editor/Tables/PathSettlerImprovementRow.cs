using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathSettlerImprovementRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("countResource00")]
	public uint CountResource00 { get; set; }

	[Column("countResource01")]
	public uint CountResource01 { get; set; }

	[Column("countResource02")]
	public uint CountResource02 { get; set; }

	[Column("countRecontributionResource00")]
	public uint CountRecontributionResource00 { get; set; }

	[Column("countRecontributionResource01")]
	public uint CountRecontributionResource01 { get; set; }

	[Column("countRecontributionResource02")]
	public uint CountRecontributionResource02 { get; set; }

	[Column("spell4IdDisplay")]
	public uint Spell4IdDisplay { get; set; }
}
