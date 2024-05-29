using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelCameraRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("EnumName")]
	public string EnumName { get; set; } = string.Empty;
}