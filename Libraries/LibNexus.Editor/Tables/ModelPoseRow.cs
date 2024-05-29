using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelPoseRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("sequenceId")]
	public uint SequenceId { get; set; }

	[Column("description")]
	public string Description { get; set; } = string.Empty;

	[Column("modelPoseIdBase")]
	public uint ModelPoseIdBase { get; set; }

	[Column("modelPoseTypeEnum")]
	public uint ModelPoseTypeEnum { get; set; }
}
