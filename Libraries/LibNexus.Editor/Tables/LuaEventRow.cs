using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class LuaEventRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("eventName")]
	public string EventName { get; set; } = string.Empty;

	[Column("parameters")]
	public string Parameters { get; set; } = string.Empty;
}
