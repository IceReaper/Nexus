using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingDecorTypeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("luaString")]
	public string LuaString { get; set; } = string.Empty;
}
