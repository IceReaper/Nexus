using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelEventVisualJoinRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("unitVisualTypeId")]
	public uint UnitVisualTypeId { get; set; }

	[Column("itemVisualTypeId")]
	public uint ItemVisualTypeId { get; set; }

	[Column("materialTypeId")]
	public uint MaterialTypeId { get; set; }

	[Column("modelEventId")]
	public uint ModelEventId { get; set; }

	[Column("visualEffectId")]
	public uint VisualEffectId { get; set; }

	[Column("modelSequenceId")]
	public uint ModelSequenceId { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }
}
