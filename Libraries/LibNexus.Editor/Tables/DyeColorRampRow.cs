using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class DyeColorRampRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("rampIndex")]
	public uint RampIndex { get; set; }

	[Column("costMultiplier")]
	public float CostMultiplier { get; set; }

	[Column("componentMapEnum")]
	public uint ComponentMapEnum { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }
}
