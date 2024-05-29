using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class QuestDirectionEntryRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("worldLocation2Id")]
	public uint WorldLocation2Id { get; set; }

	[Column("worldLocation2IdInactive")]
	public uint WorldLocation2IdInactive { get; set; }

	[Column("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[Column("questDirectionEntryFlags")]
	public uint QuestDirectionEntryFlags { get; set; }

	[Column("questDirectionFactionEnum")]
	public uint QuestDirectionFactionEnum { get; set; }
}
