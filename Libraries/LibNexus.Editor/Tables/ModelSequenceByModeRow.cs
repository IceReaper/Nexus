using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelSequenceByModeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("modelSequenceId")]
	public uint ModelSequenceId { get; set; }

	[Column("modelSequenceIdSwim")]
	public uint ModelSequenceIdSwim { get; set; }

	[Column("modelSequenceIdHover")]
	public uint ModelSequenceIdHover { get; set; }

	[Column("modelSequenceIdFly")]
	public uint ModelSequenceIdFly { get; set; }
}
