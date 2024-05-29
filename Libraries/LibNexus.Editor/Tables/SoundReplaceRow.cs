using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SoundReplaceRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("soundReplaceDescriptionId")]
	public uint SoundReplaceDescriptionId { get; set; }

	[Column("soundEventIdOld")]
	public uint SoundEventIdOld { get; set; }

	[Column("soundEventIdNew")]
	public uint SoundEventIdNew { get; set; }
}
