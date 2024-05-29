using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ColorShiftRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("texturePath")]
	public string TexturePath { get; set; } = string.Empty;

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[Column("previewSwatchIcon")]
	public string PreviewSwatchIcon { get; set; } = string.Empty;
}
