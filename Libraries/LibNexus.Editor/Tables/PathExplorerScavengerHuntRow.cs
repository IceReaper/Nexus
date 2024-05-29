using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathExplorerScavengerHuntRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("creature2IdStart")]
	public uint Creature2IdStart { get; set; }

	[Column("pathExplorerScavengerClueId00")]
	public uint PathExplorerScavengerClueId00 { get; set; }

	[Column("pathExplorerScavengerClueId01")]
	public uint PathExplorerScavengerClueId01 { get; set; }

	[Column("pathExplorerScavengerClueId02")]
	public uint PathExplorerScavengerClueId02 { get; set; }

	[Column("pathExplorerScavengerClueId03")]
	public uint PathExplorerScavengerClueId03 { get; set; }

	[Column("pathExplorerScavengerClueId04")]
	public uint PathExplorerScavengerClueId04 { get; set; }

	[Column("pathExplorerScavengerClueId05")]
	public uint PathExplorerScavengerClueId05 { get; set; }

	[Column("pathExplorerScavengerClueId06")]
	public uint PathExplorerScavengerClueId06 { get; set; }

	[Column("localizedTextIdStart")]
	public uint LocalizedTextIdStart { get; set; }

	[Column("spell4IdRelic")]
	public uint Spell4IdRelic { get; set; }

	[Column("assetPathSprite")]
	public string AssetPathSprite { get; set; } = string.Empty;
}
