using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MiniMapMarkerRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("luaName")]
	public string LuaName { get; set; } = string.Empty;
}
