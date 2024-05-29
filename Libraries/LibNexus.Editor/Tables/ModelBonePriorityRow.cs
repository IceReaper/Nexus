using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelBonePriorityRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("BoneID")]
	public uint BoneId { get; set; }

	[Column("BoneSetID")]
	public uint BoneSetId { get; set; }

	[Column("Priority")]
	public uint Priority { get; set; }
}
