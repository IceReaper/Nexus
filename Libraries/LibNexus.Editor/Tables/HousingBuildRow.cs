using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingBuildRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("description")]
	public string Description { get; set; } = string.Empty;

	[Column("assetPath")]
	public string AssetPath { get; set; } = string.Empty;

	[Column("constructionEffectsId")]
	public uint ConstructionEffectsId { get; set; }

	[Column("buildPreDelayTimeMS")]
	public float BuildPreDelayTimeMs { get; set; }

	[Column("buildPostDelayTimeMS")]
	public float BuildPostDelayTimeMs { get; set; }

	[Column("buildTime00")]
	public float BuildTime00 { get; set; }

	[Column("buildTime01")]
	public float BuildTime01 { get; set; }

	[Column("buildTime02")]
	public float BuildTime02 { get; set; }

	[Column("buildTime03")]
	public float BuildTime03 { get; set; }

	[Column("buildTime04")]
	public float BuildTime04 { get; set; }

	[Column("buildTime05")]
	public float BuildTime05 { get; set; }

	[Column("buildTime06")]
	public float BuildTime06 { get; set; }

	[Column("buildTime07")]
	public float BuildTime07 { get; set; }

	[Column("modelSequenceId00")]
	public uint ModelSequenceId00 { get; set; }

	[Column("modelSequenceId01")]
	public uint ModelSequenceId01 { get; set; }

	[Column("modelSequenceId02")]
	public uint ModelSequenceId02 { get; set; }

	[Column("modelSequenceId03")]
	public uint ModelSequenceId03 { get; set; }

	[Column("modelSequenceId04")]
	public uint ModelSequenceId04 { get; set; }

	[Column("modelSequenceId05")]
	public uint ModelSequenceId05 { get; set; }

	[Column("modelSequenceId06")]
	public uint ModelSequenceId06 { get; set; }

	[Column("modelSequenceId07")]
	public uint ModelSequenceId07 { get; set; }
}
