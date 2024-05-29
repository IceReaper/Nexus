using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class UnitRaceRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("soundImpactDescriptionIdOrigin")]
	public uint SoundImpactDescriptionIdOrigin { get; set; }

	[Column("soundImpactDescriptionIdTarget")]
	public uint SoundImpactDescriptionIdTarget { get; set; }

	[Column("unitVisualTypeId")]
	public uint UnitVisualTypeId { get; set; }

	[Column("soundEventIdAggro")]
	public uint SoundEventIdAggro { get; set; }

	[Column("soundEventIdAware")]
	public uint SoundEventIdAware { get; set; }

	[Column("soundSwitchIdModel")]
	public uint SoundSwitchIdModel { get; set; }

	[Column("soundCombatLoopId")]
	public uint SoundCombatLoopId { get; set; }
}
