using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PvPRatingFloorRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("pvpRatingTypeEnum")]
	public uint PvpRatingTypeEnum { get; set; }

	[Column("floorValue")]
	public uint FloorValue { get; set; }

	[Column("localizedTextIdLabel")]
	public uint LocalizedTextIdLabel { get; set; }
}
