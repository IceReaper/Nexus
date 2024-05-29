using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SkyTrackCloudSetRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("count")]
	public uint Count { get; set; }

	[Column("minSize00")]
	public float MinSize00 { get; set; }

	[Column("minSize01")]
	public float MinSize01 { get; set; }

	[Column("minSize02")]
	public float MinSize02 { get; set; }

	[Column("minSize03")]
	public float MinSize03 { get; set; }

	[Column("minSize04")]
	public float MinSize04 { get; set; }

	[Column("minSize05")]
	public float MinSize05 { get; set; }

	[Column("minSize06")]
	public float MinSize06 { get; set; }

	[Column("minSize07")]
	public float MinSize07 { get; set; }

	[Column("minSize08")]
	public float MinSize08 { get; set; }

	[Column("minSize09")]
	public float MinSize09 { get; set; }

	[Column("minSize10")]
	public float MinSize10 { get; set; }

	[Column("minSize11")]
	public float MinSize11 { get; set; }

	[Column("maxSize00")]
	public float MaxSize00 { get; set; }

	[Column("maxSize01")]
	public float MaxSize01 { get; set; }

	[Column("maxSize02")]
	public float MaxSize02 { get; set; }

	[Column("maxSize03")]
	public float MaxSize03 { get; set; }

	[Column("maxSize04")]
	public float MaxSize04 { get; set; }

	[Column("maxSize05")]
	public float MaxSize05 { get; set; }

	[Column("maxSize06")]
	public float MaxSize06 { get; set; }

	[Column("maxSize07")]
	public float MaxSize07 { get; set; }

	[Column("maxSize08")]
	public float MaxSize08 { get; set; }

	[Column("maxSize09")]
	public float MaxSize09 { get; set; }

	[Column("maxSize10")]
	public float MaxSize10 { get; set; }

	[Column("maxSize11")]
	public float MaxSize11 { get; set; }

	[Column("model00")]
	public string Model00 { get; set; } = string.Empty;

	[Column("model01")]
	public string Model01 { get; set; } = string.Empty;

	[Column("model02")]
	public string Model02 { get; set; } = string.Empty;

	[Column("model03")]
	public string Model03 { get; set; } = string.Empty;

	[Column("model04")]
	public string Model04 { get; set; } = string.Empty;

	[Column("model05")]
	public string Model05 { get; set; } = string.Empty;

	[Column("model06")]
	public string Model06 { get; set; } = string.Empty;

	[Column("model07")]
	public string Model07 { get; set; } = string.Empty;

	[Column("model08")]
	public string Model08 { get; set; } = string.Empty;

	[Column("model09")]
	public string Model09 { get; set; } = string.Empty;

	[Column("model10")]
	public string Model10 { get; set; } = string.Empty;

	[Column("model11")]
	public string Model11 { get; set; } = string.Empty;
}
