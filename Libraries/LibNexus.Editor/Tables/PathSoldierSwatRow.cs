using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathSoldierSwatRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("creature2Id")]
	public uint Creature2Id { get; set; }

	[Column("targetGroupId")]
	public uint TargetGroupId { get; set; }

	[Column("count")]
	public uint Count { get; set; }

	[Column("virtualItemIdDisplay")]
	public uint VirtualItemIdDisplay { get; set; }
}
