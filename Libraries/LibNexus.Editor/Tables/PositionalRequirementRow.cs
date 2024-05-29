using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PositionalRequirementRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("angleCenter")]
	public uint AngleCenter { get; set; }

	[Column("angleRange")]
	public uint AngleRange { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }
}
