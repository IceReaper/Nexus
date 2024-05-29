using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathExplorerNodeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("pathExplorerAreaId")]
	public uint PathExplorerAreaId { get; set; }

	[Column("worldLocation2Id")]
	public uint WorldLocation2Id { get; set; }

	[Column("spline2Id")]
	public uint Spline2Id { get; set; }

	[Column("localizedTextIdSettlerButton")]
	public uint LocalizedTextIdSettlerButton { get; set; }

	[Column("questDirectionId")]
	public uint QuestDirectionId { get; set; }

	[Column("visualEffectId")]
	public uint VisualEffectId { get; set; }
}
