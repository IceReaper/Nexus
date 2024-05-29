using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PlayerNotificationTypeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("priority")]
	public uint Priority { get; set; }

	[Column("lifetimeMs")]
	public uint LifetimeMs { get; set; }
}
