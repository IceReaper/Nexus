using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Faction2RelationshipRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("factionId0")]
	public uint FactionId0 { get; set; }

	[Column("factionId1")]
	public uint FactionId1 { get; set; }

	[Column("factionLevel")]
	public uint FactionLevel { get; set; }
}
