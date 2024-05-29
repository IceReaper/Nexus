using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemDisplaySourceEntryRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("itemSourceId")]
	public uint ItemSourceId { get; set; }

	[Column("item2TypeId")]
	public uint Item2TypeId { get; set; }

	[Column("itemMinLevel")]
	public uint ItemMinLevel { get; set; }

	[Column("itemMaxLevel")]
	public uint ItemMaxLevel { get; set; }

	[Column("itemDisplayId")]
	public uint ItemDisplayId { get; set; }

	[Column("icon")]
	public string Icon { get; set; } = string.Empty;
}
