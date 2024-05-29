using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PrerequisiteTypeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdError")]
	public uint LocalizedTextIdError { get; set; }
}
