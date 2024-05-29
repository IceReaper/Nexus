using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventUnitPropertyModifierRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("publicEventId")]
	public uint PublicEventId { get; set; }

	[Column("unitProperty2Id")]
	public uint UnitProperty2Id { get; set; }

	[Column("scalar")]
	public float Scalar { get; set; }
}
