using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Creature2AffiliationRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[Column("miniMapMarkerId")]
	public uint MiniMapMarkerId { get; set; }

	[Column("overheadIconAssetPath")]
	public string OverheadIconAssetPath { get; set; } = string.Empty;
}
