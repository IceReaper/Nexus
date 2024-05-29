using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class VitalRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdDisplayText")]
	public uint LocalizedTextIdDisplayText { get; set; }
}
