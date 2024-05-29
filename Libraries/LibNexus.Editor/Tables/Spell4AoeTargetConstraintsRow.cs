using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4AoeTargetConstraintsRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("angle")]
	public float Angle { get; set; }

	[Column("targetCount")]
	public uint TargetCount { get; set; }

	[Column("minRange")]
	public float MinRange { get; set; }

	[Column("maxRange")]
	public float MaxRange { get; set; }

	[Column("targetSelection")]
	public uint TargetSelection { get; set; }
}
