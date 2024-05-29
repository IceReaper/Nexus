using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class VirtualItemRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("buttonIcon")]
	public string ButtonIcon { get; set; } = string.Empty;

	[Column("item2TypeId")]
	public uint Item2TypeId { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdFlavor")]
	public uint LocalizedTextIdFlavor { get; set; }

	[Column("itemQualityId")]
	public uint ItemQualityId { get; set; }
}
