using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventVirtualItemDepotRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("creature2Id")]
	public uint Creature2Id { get; set; }

	[Column("virtualItemId00")]
	public uint VirtualItemId00 { get; set; }

	[Column("virtualItemId01")]
	public uint VirtualItemId01 { get; set; }

	[Column("virtualItemId02")]
	public uint VirtualItemId02 { get; set; }

	[Column("virtualItemId03")]
	public uint VirtualItemId03 { get; set; }

	[Column("virtualItemId04")]
	public uint VirtualItemId04 { get; set; }

	[Column("virtualItemId05")]
	public uint VirtualItemId05 { get; set; }
}
