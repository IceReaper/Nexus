using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CharacterCreationArmorSetRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("creationGearSetEnum")]
	public uint CreationGearSetEnum { get; set; }

	[Column("classId")]
	public uint ClassId { get; set; }

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

	[Column("itemDisplayId06")]
	public uint ItemDisplayId06 { get; set; }

	[Column("itemDisplayId07")]
	public uint ItemDisplayId07 { get; set; }

	[Column("itemDisplayId08")]
	public uint ItemDisplayId08 { get; set; }

	[Column("itemDisplayId09")]
	public uint ItemDisplayId09 { get; set; }

	[Column("itemDisplayId10")]
	public uint ItemDisplayId10 { get; set; }

	[Column("itemDisplayId11")]
	public uint ItemDisplayId11 { get; set; }
}
