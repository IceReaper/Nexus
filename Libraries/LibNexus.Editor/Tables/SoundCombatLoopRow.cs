using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SoundCombatLoopRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("soundEventIdStart")]
	public uint SoundEventIdStart { get; set; }

	[Column("soundEventIdStop")]
	public uint SoundEventIdStop { get; set; }

	[Column("soundParameterIdUnitsInCombat")]
	public uint SoundParameterIdUnitsInCombat { get; set; }
}
