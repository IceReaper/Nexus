using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Creature2OutfitGroupEntryRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("creature2OutfitGroupId")]
	public uint Creature2OutfitGroupId { get; set; }

	[Column("creature2OutfitInfoId")]
	public uint Creature2OutfitInfoId { get; set; }

	[Column("weight")]
	public uint Weight { get; set; }
}
