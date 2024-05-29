using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class LevelDifferentialAttributeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[Column("levelDifferentialValue")]
	public uint LevelDifferentialValue { get; set; }

	[Column("questXpMultiplier")]
	public float QuestXpMultiplier { get; set; }
}
