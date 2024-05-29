using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Creature2DisplayGroupEntryRow
{
	[Column("id")]
	public uint Id { get; set; }

	[Column("creature2DisplayGroupId")]
	public uint Creature2DisplayGroupId { get; set; }

	[Column("creature2DisplayInfoId")]
	public uint Creature2DisplayInfoId { get; set; }

	[Column("weight")]
	public uint Weight { get; set; }
}
