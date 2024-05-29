using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class LevelUpUnlockRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("levelUpUnlockSystemEnum")]
	public uint LevelUpUnlockSystemEnum { get; set; }

	[Column("level")]
	public uint Level { get; set; }

	[Column("levelUpUnlockTypeId")]
	public uint LevelUpUnlockTypeId { get; set; }

	[Column("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[Column("displayIcon")]
	public string DisplayIcon { get; set; } = string.Empty;

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[Column("levelUpUnlockValue")]
	public uint LevelUpUnlockValue { get; set; }
}
