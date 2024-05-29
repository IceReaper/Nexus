using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class StoreDisplayInfoRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("displayType")]
	public uint DisplayType { get; set; }

	[Column("displayValue")]
	public uint DisplayValue { get; set; }

	[Column("modelCameraId")]
	public uint ModelCameraId { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }
}
