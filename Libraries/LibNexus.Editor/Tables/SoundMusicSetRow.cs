using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SoundMusicSetRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("soundEventIdStart")]
	public uint SoundEventIdStart { get; set; }

	[Column("soundEventIdStop")]
	public uint SoundEventIdStop { get; set; }

	[Column("restartDelayMin")]
	public float RestartDelayMin { get; set; }

	[Column("restartDelayMax")]
	public float RestartDelayMax { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }
}
