using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SoundUiContextRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("luaVariableName")]
	public string LuaVariableName { get; set; } = string.Empty;

	[Column("soundEventId")]
	public uint SoundEventId { get; set; }
}
