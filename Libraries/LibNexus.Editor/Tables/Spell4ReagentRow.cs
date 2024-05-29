using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4ReagentRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("reagentType")]
	public uint ReagentType { get; set; }

	[Column("reagentTypeObjectId")]
	public uint ReagentTypeObjectId { get; set; }

	[Column("reagentCount")]
	public uint ReagentCount { get; set; }

	[Column("consumeReagent")]
	public bool ConsumeReagent { get; set; }
}
