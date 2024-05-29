using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CustomizationParameterRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("sclX")]
	public uint SclX { get; set; }

	[Column("sclY")]
	public uint SclY { get; set; }

	[Column("sclZ")]
	public uint SclZ { get; set; }

	[Column("rotX")]
	public uint RotX { get; set; }

	[Column("rotY")]
	public uint RotY { get; set; }

	[Column("rotZ")]
	public uint RotZ { get; set; }

	[Column("posX")]
	public uint PosX { get; set; }

	[Column("posY")]
	public uint PosY { get; set; }

	[Column("posZ")]
	public uint PosZ { get; set; }
}
