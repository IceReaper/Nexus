using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("assetPath")]
	public string AssetPath { get; set; } = string.Empty;

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("type")]
	public uint Type { get; set; }

	[Column("screenPath")]
	public string ScreenPath { get; set; } = string.Empty;

	[Column("screenModelPath")]
	public string ScreenModelPath { get; set; } = string.Empty;

	[Column("chunkBounds00")]
	public uint ChunkBounds00 { get; set; }

	[Column("chunkBounds01")]
	public uint ChunkBounds01 { get; set; }

	[Column("chunkBounds02")]
	public uint ChunkBounds02 { get; set; }

	[Column("chunkBounds03")]
	public uint ChunkBounds03 { get; set; }

	[Column("plugAverageHeight")]
	public uint PlugAverageHeight { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("minItemLevel")]
	public uint MinItemLevel { get; set; }

	[Column("maxItemLevel")]
	public uint MaxItemLevel { get; set; }

	[Column("primeLevelOffset")]
	public uint PrimeLevelOffset { get; set; }

	[Column("primeLevelMax")]
	public uint PrimeLevelMax { get; set; }

	[Column("veteranTierScalingType")]
	public uint VeteranTierScalingType { get; set; }

	[Column("heroismMenaceLevel")]
	public uint HeroismMenaceLevel { get; set; }

	[Column("rewardRotationContentId")]
	public uint RewardRotationContentId { get; set; }
}
