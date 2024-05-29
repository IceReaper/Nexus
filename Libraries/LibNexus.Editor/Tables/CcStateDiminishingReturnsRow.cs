using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CcStateDiminishingReturnsRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }
}
