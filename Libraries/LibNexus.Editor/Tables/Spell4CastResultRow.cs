using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4CastResultRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("enumName")]
	public string EnumName { get; set; } = string.Empty;

	[Column("combatMessageTypeEnum")]
	public uint CombatMessageTypeEnum { get; set; }

	[Column("localizedTextIdDisplayText")]
	public uint LocalizedTextIdDisplayText { get; set; }

	[Column("soundEventId")]
	public uint SoundEventId { get; set; }
}
