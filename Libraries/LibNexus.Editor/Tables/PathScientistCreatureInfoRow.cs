using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathScientistCreatureInfoRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("scientistCreatureFlags")]
	public uint ScientistCreatureFlags { get; set; }

	[Column("displayIcon")]
	public string DisplayIcon { get; set; } = string.Empty;

	[Column("prerequisiteIdScan")]
	public uint PrerequisiteIdScan { get; set; }

	[Column("prerequisiteIdRawScan")]
	public uint PrerequisiteIdRawScan { get; set; }

	[Column("prerequisiteIdScanCreature")]
	public uint PrerequisiteIdScanCreature { get; set; }

	[Column("prerequisiteIdRawScanCreature")]
	public uint PrerequisiteIdRawScanCreature { get; set; }

	[Column("spell4IdBuff00")]
	public uint Spell4IdBuff00 { get; set; }

	[Column("spell4IdBuff01")]
	public uint Spell4IdBuff01 { get; set; }

	[Column("spell4IdBuff02")]
	public uint Spell4IdBuff02 { get; set; }

	[Column("spell4IdBuff03")]
	public uint Spell4IdBuff03 { get; set; }

	[Column("checklistCount")]
	public uint ChecklistCount { get; set; }

	[Column("scientistCreatureTypeEnum")]
	public uint ScientistCreatureTypeEnum { get; set; }

	[Column("lootId")]
	public uint LootId { get; set; }
}
