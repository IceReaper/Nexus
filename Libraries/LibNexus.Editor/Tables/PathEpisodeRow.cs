using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathEpisodeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdSummary")]
	public uint LocalizedTextIdSummary { get; set; }

	[Column("worldId")]
	public uint WorldId { get; set; }

	[Column("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[Column("pathTypeEnum")]
	public uint PathTypeEnum { get; set; }
}
