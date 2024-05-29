using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingMapInfoRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("worldId")]
	public uint WorldId { get; set; }

	[Column("privatePropertyCount")]
	public uint PrivatePropertyCount { get; set; }

	[Column("publicPropertyCount")]
	public uint PublicPropertyCount { get; set; }
}
