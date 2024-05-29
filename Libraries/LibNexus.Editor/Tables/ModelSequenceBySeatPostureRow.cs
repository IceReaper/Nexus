using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelSequenceBySeatPostureRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("modelSequenceId")]
	public uint ModelSequenceId { get; set; }

	[Column("modelSequenceIdNarrow")]
	public uint ModelSequenceIdNarrow { get; set; }

	[Column("modelSequenceIdMedium")]
	public uint ModelSequenceIdMedium { get; set; }

	[Column("modelSequenceIdWide")]
	public uint ModelSequenceIdWide { get; set; }

	[Column("modelSequenceIdBike")]
	public uint ModelSequenceIdBike { get; set; }

	[Column("modelSequenceIdHoverBoard")]
	public uint ModelSequenceIdHoverBoard { get; set; }

	[Column("modelSequenceIdGlider")]
	public uint ModelSequenceIdGlider { get; set; }

	[Column("modelSequenceIdTank")]
	public uint ModelSequenceIdTank { get; set; }
}
