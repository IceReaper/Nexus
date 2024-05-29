using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventStatDisplayRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("publicEventTypeEnum")]
	public uint PublicEventTypeEnum { get; set; }

	[Column("publicEventId")]
	public uint PublicEventId { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }
}
