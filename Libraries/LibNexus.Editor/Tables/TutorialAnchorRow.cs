using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TutorialAnchorRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("tutorialAnchorOrientationEnum")]
	public uint TutorialAnchorOrientationEnum { get; set; }

	[Column("hOffset")]
	public uint HOffset { get; set; }

	[Column("vOffset")]
	public uint VOffset { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }
}
