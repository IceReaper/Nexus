using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CharacterTitleRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("characterTitleCategoryId")]
	public uint CharacterTitleCategoryId { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[Column("spell4IdActivate")]
	public uint Spell4IdActivate { get; set; }

	[Column("lifeTimeSeconds")]
	public uint LifeTimeSeconds { get; set; }

	[Column("playerTitleFlagsEnum")]
	public uint PlayerTitleFlagsEnum { get; set; }

	[Column("scheduleId")]
	public uint ScheduleId { get; set; }
}
