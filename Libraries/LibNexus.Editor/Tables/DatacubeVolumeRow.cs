using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class DatacubeVolumeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("assetPath")]
	public string AssetPath { get; set; } = string.Empty;

	[Column("datacubeId00")]
	public uint DatacubeId00 { get; set; }

	[Column("datacubeId01")]
	public uint DatacubeId01 { get; set; }

	[Column("datacubeId02")]
	public uint DatacubeId02 { get; set; }

	[Column("datacubeId03")]
	public uint DatacubeId03 { get; set; }

	[Column("datacubeId04")]
	public uint DatacubeId04 { get; set; }

	[Column("datacubeId05")]
	public uint DatacubeId05 { get; set; }

	[Column("datacubeId06")]
	public uint DatacubeId06 { get; set; }

	[Column("datacubeId07")]
	public uint DatacubeId07 { get; set; }

	[Column("datacubeId08")]
	public uint DatacubeId08 { get; set; }

	[Column("datacubeId09")]
	public uint DatacubeId09 { get; set; }

	[Column("datacubeId10")]
	public uint DatacubeId10 { get; set; }

	[Column("datacubeId11")]
	public uint DatacubeId11 { get; set; }

	[Column("datacubeId12")]
	public uint DatacubeId12 { get; set; }

	[Column("datacubeId13")]
	public uint DatacubeId13 { get; set; }

	[Column("datacubeId14")]
	public uint DatacubeId14 { get; set; }

	[Column("datacubeId15")]
	public uint DatacubeId15 { get; set; }
}
