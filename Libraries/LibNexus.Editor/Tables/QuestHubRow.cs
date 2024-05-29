using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class QuestHubRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("worldLocation2Id")]
	public uint WorldLocation2Id { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }
}
