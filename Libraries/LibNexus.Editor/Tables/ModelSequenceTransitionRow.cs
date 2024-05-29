using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelSequenceTransitionRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("modelSequenceIdFrom")]
	public uint ModelSequenceIdFrom { get; set; }

	[Column("modelSequenceIdTo")]
	public uint ModelSequenceIdTo { get; set; }

	[Column("modelSequenceIdTransition")]
	public uint ModelSequenceIdTransition { get; set; }
}
