using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MapZoneSpriteRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("spriteName")]
	public string SpriteName { get; set; } = string.Empty;
}
