using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathScientistExperimentationPatternRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[Column("pathMissionId")]
	public uint PathMissionId { get; set; }

	[Column("pathScientistExperimentationId")]
	public uint PathScientistExperimentationId { get; set; }

	[Column("iconAssetPath")]
	public string IconAssetPath { get; set; } = string.Empty;
}
