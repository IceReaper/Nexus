using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ResourceConversionRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("resourceConversionTypeEnum")]
	public uint ResourceConversionTypeEnum { get; set; }

	[Column("sourceId")]
	public uint SourceId { get; set; }

	[Column("sourceCount")]
	public uint SourceCount { get; set; }

	[Column("targetId")]
	public uint TargetId { get; set; }

	[Column("targetCount")]
	public uint TargetCount { get; set; }

	[Column("surchargeId")]
	public uint SurchargeId { get; set; }

	[Column("surchargeCount")]
	public uint SurchargeCount { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }
}
