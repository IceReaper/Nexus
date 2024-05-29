using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SoundContextRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("eventId")]
	public uint EventId { get; set; }

	[Column("type")]
	public uint Type { get; set; }
}
