using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Creature2OverridePropertiesRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("creature2Id")]
	public uint Creature2Id { get; set; }

	[Column("unitPropertyIndex")]
	public uint UnitPropertyIndex { get; set; }

	[Column("unitPropertyValue")]
	public float UnitPropertyValue { get; set; }
}
