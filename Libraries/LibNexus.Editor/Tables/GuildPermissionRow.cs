using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class GuildPermissionRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[Column("luaVariable")]
	public string LuaVariable { get; set; } = string.Empty;

	[Column("localizedTextIdCommand")]
	public uint LocalizedTextIdCommand { get; set; }

	[Column("guildTypeEnumFlags")]
	public uint GuildTypeEnumFlags { get; set; }

	[Column("displayIndex")]
	public uint DisplayIndex { get; set; }
}
