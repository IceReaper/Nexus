using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Creature2ActionTextRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdOnEnterCombat00")]
	public uint LocalizedTextIdOnEnterCombat00 { get; set; }

	[Column("localizedTextIdOnEnterCombat01")]
	public uint LocalizedTextIdOnEnterCombat01 { get; set; }

	[Column("localizedTextIdOnEnterCombat02")]
	public uint LocalizedTextIdOnEnterCombat02 { get; set; }

	[Column("localizedTextIdOnEnterCombat03")]
	public uint LocalizedTextIdOnEnterCombat03 { get; set; }

	[Column("chanceToSayOnEnterCombat")]
	public float ChanceToSayOnEnterCombat { get; set; }

	[Column("localizedTextIdOnDeath00")]
	public uint LocalizedTextIdOnDeath00 { get; set; }

	[Column("localizedTextIdOnDeath01")]
	public uint LocalizedTextIdOnDeath01 { get; set; }

	[Column("localizedTextIdOnDeath02")]
	public uint LocalizedTextIdOnDeath02 { get; set; }

	[Column("localizedTextIdOnDeath03")]
	public uint LocalizedTextIdOnDeath03 { get; set; }

	[Column("chanceToSayOnDeath")]
	public float ChanceToSayOnDeath { get; set; }

	[Column("localizedTextIdOnKill00")]
	public uint LocalizedTextIdOnKill00 { get; set; }

	[Column("localizedTextIdOnKill01")]
	public uint LocalizedTextIdOnKill01 { get; set; }

	[Column("localizedTextIdOnKill02")]
	public uint LocalizedTextIdOnKill02 { get; set; }

	[Column("localizedTextIdOnKill03")]
	public uint LocalizedTextIdOnKill03 { get; set; }

	[Column("chanceToSayOnKill")]
	public float ChanceToSayOnKill { get; set; }
}
