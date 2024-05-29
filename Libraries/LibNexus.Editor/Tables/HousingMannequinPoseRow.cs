using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingMannequinPoseRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("enumName")]
	public string EnumName { get; set; } = string.Empty;

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("modelSequenceId")]
	public uint ModelSequenceId { get; set; }
}
