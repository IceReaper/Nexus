using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemBudgetRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("budget00")]
	public float Budget00 { get; set; }

	[Column("budget01")]
	public float Budget01 { get; set; }

	[Column("budget02")]
	public float Budget02 { get; set; }

	[Column("budget03")]
	public float Budget03 { get; set; }

	[Column("budget04")]
	public float Budget04 { get; set; }
}
