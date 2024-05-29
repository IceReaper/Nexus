using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingWarplotBossTokenRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("spell4IdSummon")]
	public uint Spell4IdSummon { get; set; }

	[Column("minimumUpgradeTierEnum")]
	public uint MinimumUpgradeTierEnum { get; set; }

	[Column("housingPlugItemIdLinked")]
	public uint HousingPlugItemIdLinked { get; set; }
}
