using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SpellCoolDownRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("cooldownTime")]
	public uint CooldownTime { get; set; }
}
