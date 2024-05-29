using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MatchingMapPrerequisiteRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("matchingGameMapId")]
	public uint MatchingGameMapId { get; set; }

	[Column("matchingEligibilityFlagEnum")]
	public uint MatchingEligibilityFlagEnum { get; set; }
}
