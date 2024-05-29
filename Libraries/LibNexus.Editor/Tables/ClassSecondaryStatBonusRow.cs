using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ClassSecondaryStatBonusRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("unitProperty2IdSecondaryStat00")]
	public uint UnitProperty2IdSecondaryStat00 { get; set; }

	[Column("unitProperty2IdSecondaryStat01")]
	public uint UnitProperty2IdSecondaryStat01 { get; set; }

	[Column("unitProperty2IdSecondaryStat02")]
	public uint UnitProperty2IdSecondaryStat02 { get; set; }

	[Column("modifier00")]
	public float Modifier00 { get; set; }

	[Column("modifier01")]
	public float Modifier01 { get; set; }

	[Column("modifier02")]
	public float Modifier02 { get; set; }
}
