using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class InstancePortalRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("minLevel")]
	public uint MinLevel { get; set; }

	[Column("maxLevel")]
	public uint MaxLevel { get; set; }

	[Column("expectedCompletionTime")]
	public uint ExpectedCompletionTime { get; set; }

	[Column("instancePortalTypeEnum")]
	public uint InstancePortalTypeEnum { get; set; }
}
