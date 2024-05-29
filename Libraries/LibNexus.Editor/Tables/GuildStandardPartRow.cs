using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class GuildStandardPartRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("guildStandardPartTypeEnum")]
	public uint GuildStandardPartTypeEnum { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("itemDisplayIdStandard")]
	public uint ItemDisplayIdStandard { get; set; }
}
