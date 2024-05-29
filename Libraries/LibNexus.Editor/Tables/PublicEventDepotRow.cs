using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventDepotRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("creature2Id")]
	public uint Creature2Id { get; set; }

	[Column("item2Id")]
	public uint Item2Id { get; set; }
}
