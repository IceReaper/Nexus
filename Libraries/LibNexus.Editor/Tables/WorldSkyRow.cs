using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldSkyRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("assetPath")]
	public string AssetPath { get; set; } = string.Empty;

	[Column("assetPathInFlux")]
	public string AssetPathInFlux { get; set; } = string.Empty;

	[Column("color")]
	public uint Color { get; set; }
}
