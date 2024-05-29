using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4RunnerRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("spriteName")]
	public string SpriteName { get; set; } = string.Empty;

	[Column("redTint")]
	public float RedTint { get; set; }

	[Column("greenTint")]
	public float GreenTint { get; set; }

	[Column("blueTint")]
	public float BlueTint { get; set; }

	[Column("alphaTint")]
	public float AlphaTint { get; set; }

	[Column("rate")]
	public float Rate { get; set; }
}
