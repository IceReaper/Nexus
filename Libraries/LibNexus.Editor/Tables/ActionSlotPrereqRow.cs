using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ActionSlotPrereqRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("slotIndex")]
	public uint SlotIndex { get; set; }

	[Column("prerequisiteIdUnlock")]
	public uint PrerequisiteIdUnlock { get; set; }
}
