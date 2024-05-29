using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldWaterFogRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("fogStart")]
	public float FogStart { get; set; }

	[Column("fogEnd")]
	public float FogEnd { get; set; }

	[Column("fogStartUW")]
	public float FogStartUw { get; set; }

	[Column("fogEndUW")]
	public float FogEndUw { get; set; }

	[Column("modStart")]
	public float ModStart { get; set; }

	[Column("modEnd")]
	public float ModEnd { get; set; }

	[Column("modStartUW")]
	public float ModStartUw { get; set; }

	[Column("modEndUW")]
	public float ModEndUw { get; set; }

	[Column("skyColorIndex")]
	public uint SkyColorIndex { get; set; }
}
