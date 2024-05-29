using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelBoneRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("XSIName")]
	public string XsiName { get; set; } = string.Empty;
}
