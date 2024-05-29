using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TargetGroupRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdDisplayString")]
	public uint LocalizedTextIdDisplayString { get; set; }

	[Column("type")]
	public uint Type { get; set; }

	[Column("data0")]
	public uint Data0 { get; set; }

	[Column("data1")]
	public uint Data1 { get; set; }

	[Column("data2")]
	public uint Data2 { get; set; }

	[Column("data3")]
	public uint Data3 { get; set; }

	[Column("data4")]
	public uint Data4 { get; set; }

	[Column("data5")]
	public uint Data5 { get; set; }

	[Column("data6")]
	public uint Data6 { get; set; }
}
