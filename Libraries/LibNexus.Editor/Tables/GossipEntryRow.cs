using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class GossipEntryRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("gossipSetId")]
	public uint GossipSetId { get; set; }

	[Column("indexOrder")]
	public uint IndexOrder { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }
}
