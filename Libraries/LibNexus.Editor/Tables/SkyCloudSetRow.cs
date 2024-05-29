using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SkyCloudSetRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("density")]
	public float Density { get; set; }

	[Column("skyTrackCloudSetId00")]
	public uint SkyTrackCloudSetId00 { get; set; }

	[Column("skyTrackCloudSetId01")]
	public uint SkyTrackCloudSetId01 { get; set; }

	[Column("skyTrackCloudSetId02")]
	public uint SkyTrackCloudSetId02 { get; set; }

	[Column("skyTrackCloudSetId03")]
	public uint SkyTrackCloudSetId03 { get; set; }

	[Column("skyTrackCloudSetId04")]
	public uint SkyTrackCloudSetId04 { get; set; }

	[Column("skyTrackCloudSetId05")]
	public uint SkyTrackCloudSetId05 { get; set; }
}
