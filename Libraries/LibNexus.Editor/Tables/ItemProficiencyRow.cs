using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemProficiencyRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("bitMask")]
	public uint BitMask { get; set; }

	[Column("localizedTextIdString")]
	public uint LocalizedTextIdString { get; set; }
}
