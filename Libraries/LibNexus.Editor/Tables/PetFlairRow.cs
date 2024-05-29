using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PetFlairRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("unlockBitIndex00")]
	public uint UnlockBitIndex00 { get; set; }

	[Column("unlockBitIndex01")]
	public uint UnlockBitIndex01 { get; set; }

	[Column("type")]
	public uint Type { get; set; }

	[Column("spell4Id")]
	public uint Spell4Id { get; set; }

	[Column("localizedTextIdTooltip")]
	public uint LocalizedTextIdTooltip { get; set; }

	[Column("itemDisplayId00")]
	public uint ItemDisplayId00 { get; set; }

	[Column("itemDisplayId01")]
	public uint ItemDisplayId01 { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }
}
