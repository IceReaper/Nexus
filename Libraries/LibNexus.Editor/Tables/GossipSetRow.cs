using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class GossipSetRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("gossipProximityEnum")]
	public uint GossipProximityEnum { get; set; }

	[Column("cooldown")]
	public uint Cooldown { get; set; }
}
