using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SpellLevelRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("classId")]
	public uint ClassId { get; set; }

	[Column("characterLevel")]
	public uint CharacterLevel { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[Column("spell4Id")]
	public uint Spell4Id { get; set; }

	[Column("costMultiplier")]
	public float CostMultiplier { get; set; }
}
