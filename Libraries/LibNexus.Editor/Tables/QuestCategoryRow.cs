using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class QuestCategoryRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("description")]
	public string Description { get; set; } = string.Empty;

	[Column("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[Column("questCategoryTypeEnum")]
	public uint QuestCategoryTypeEnum { get; set; }
}
