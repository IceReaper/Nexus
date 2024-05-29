using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class AchievementSubGroupRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("tier")]
	public uint Tier { get; set; }
}
