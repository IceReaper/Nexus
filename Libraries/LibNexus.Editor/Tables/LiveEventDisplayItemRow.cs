using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class LiveEventDisplayItemRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("liveEventId")]
	public uint LiveEventId { get; set; }

	[Column("item2Id")]
	public uint Item2Id { get; set; }

	[Column("storeLinkId")]
	public uint StoreLinkId { get; set; }
}
