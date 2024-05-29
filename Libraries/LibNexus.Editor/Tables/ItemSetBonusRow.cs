using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemSetBonusRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("requiredPower")]
	public uint RequiredPower { get; set; }

	[Column("unitProperty2Id")]
	public uint UnitProperty2Id { get; set; }

	[Column("scalar")]
	public float Scalar { get; set; }

	[Column("offset")]
	public float Offset { get; set; }

	[Column("spell4Id")]
	public uint Spell4Id { get; set; }
}
