using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Creature2OutfitInfoRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("itemDisplayId00")]
	public uint ItemDisplayId00 { get; set; }

	[Column("itemDisplayId01")]
	public uint ItemDisplayId01 { get; set; }

	[Column("itemDisplayId02")]
	public uint ItemDisplayId02 { get; set; }

	[Column("itemDisplayId03")]
	public uint ItemDisplayId03 { get; set; }

	[Column("itemDisplayId04")]
	public uint ItemDisplayId04 { get; set; }

	[Column("itemDisplayId05")]
	public uint ItemDisplayId05 { get; set; }

	[Column("itemColorSetId00")]
	public uint ItemColorSetId00 { get; set; }

	[Column("itemColorSetId01")]
	public uint ItemColorSetId01 { get; set; }

	[Column("itemColorSetId02")]
	public uint ItemColorSetId02 { get; set; }

	[Column("itemColorSetId03")]
	public uint ItemColorSetId03 { get; set; }

	[Column("itemColorSetId04")]
	public uint ItemColorSetId04 { get; set; }

	[Column("itemColorSetId05")]
	public uint ItemColorSetId05 { get; set; }
}
