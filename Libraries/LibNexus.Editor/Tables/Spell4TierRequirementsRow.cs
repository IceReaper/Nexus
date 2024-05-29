using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4TierRequirementsRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("tierIndex")]
	public uint TierIndex { get; set; }

	[Column("levelRequirement")]
	public uint LevelRequirement { get; set; }
}
