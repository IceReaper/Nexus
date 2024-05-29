using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SpellPhaseRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("phaseDelay")]
	public uint PhaseDelay { get; set; }

	[Column("phaseFlags")]
	public uint PhaseFlags { get; set; }

	[Column("orderIndex")]
	public uint OrderIndex { get; set; }

	[Column("spell4IdOwner")]
	public uint Spell4IdOwner { get; set; }
}
