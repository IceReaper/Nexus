using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelSequenceRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("description")]
	public string Description { get; set; } = string.Empty;

	[Column("FallBackID")]
	public uint FallBackId { get; set; }

	[Column("flag")]
	public uint Flag { get; set; }
}
