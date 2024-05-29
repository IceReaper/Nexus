using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemColorSetRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("dyeColorRampId00")]
	public uint DyeColorRampId00 { get; set; }

	[Column("dyeColorRampId01")]
	public uint DyeColorRampId01 { get; set; }

	[Column("dyeColorRampId02")]
	public uint DyeColorRampId02 { get; set; }
}
