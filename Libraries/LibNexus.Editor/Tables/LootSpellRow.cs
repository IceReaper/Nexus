using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class LootSpellRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("lootSpellTypeEnum")]
	public uint LootSpellTypeEnum { get; set; }

	[Column("lootSpellPickupEnumFlags")]
	public uint LootSpellPickupEnumFlags { get; set; }

	[Column("creature2Id")]
	public uint Creature2Id { get; set; }

	[Column("buttonIcon")]
	public string ButtonIcon { get; set; } = string.Empty;

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[Column("visualEffectId")]
	public uint VisualEffectId { get; set; }

	[Column("data")]
	public uint Data { get; set; }

	[Column("dataValue")]
	public uint DataValue { get; set; }
}
