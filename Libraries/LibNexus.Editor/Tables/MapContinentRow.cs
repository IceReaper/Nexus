using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MapContinentRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("assetPath")]
	public string AssetPath { get; set; } = string.Empty;

	[Column("imagePath")]
	public string ImagePath { get; set; } = string.Empty;

	[Column("imageWidth")]
	public uint ImageWidth { get; set; }

	[Column("imageHeight")]
	public uint ImageHeight { get; set; }

	[Column("imageOffsetX")]
	public uint ImageOffsetX { get; set; }

	[Column("imageOffsetY")]
	public uint ImageOffsetY { get; set; }

	[Column("hexMinX")]
	public uint HexMinX { get; set; }

	[Column("hexMinY")]
	public uint HexMinY { get; set; }

	[Column("hexLimX")]
	public uint HexLimX { get; set; }

	[Column("hexLimY")]
	public uint HexLimY { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }
}
