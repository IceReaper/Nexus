using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4TargetAngleRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("targetAngle")]
	public float TargetAngle { get; set; }
}
