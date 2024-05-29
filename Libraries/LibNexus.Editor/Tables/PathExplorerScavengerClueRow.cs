using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathExplorerScavengerClueRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdClue")]
	public uint LocalizedTextIdClue { get; set; }

	[Column("explorerScavengerClueTypeEnum")]
	public uint ExplorerScavengerClueTypeEnum { get; set; }

	[Column("creature2Id")]
	public uint Creature2Id { get; set; }

	[Column("targetGroupId")]
	public uint TargetGroupId { get; set; }

	[Column("activeRadius")]
	public float ActiveRadius { get; set; }

	[Column("worldLocation2IdMiniMap")]
	public uint WorldLocation2IdMiniMap { get; set; }
}
