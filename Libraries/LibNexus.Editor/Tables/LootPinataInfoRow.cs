using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class LootPinataInfoRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("item2Id")]
	public uint Item2Id { get; set; }

	[Column("item2TypeId")]
	public uint Item2TypeId { get; set; }

	[Column("item2CategoryId")]
	public uint Item2CategoryId { get; set; }

	[Column("item2FamilyId")]
	public uint Item2FamilyId { get; set; }

	[Column("virtualItemId")]
	public uint VirtualItemId { get; set; }

	[Column("accountCurrencyTypeId")]
	public uint AccountCurrencyTypeId { get; set; }

	[Column("creature2IdChest")]
	public uint Creature2IdChest { get; set; }

	[Column("mass")]
	public float Mass { get; set; }

	[Column("soundEventId")]
	public uint SoundEventId { get; set; }
}
