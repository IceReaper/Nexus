using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SoundDirectionalAmbienceRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("soundEventIdOutsideStart")]
	public uint SoundEventIdOutsideStart { get; set; }

	[Column("soundEventIdOutsideStop")]
	public uint SoundEventIdOutsideStop { get; set; }
}
