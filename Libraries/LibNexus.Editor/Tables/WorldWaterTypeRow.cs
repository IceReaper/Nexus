using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldWaterTypeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("worldWaterFogId")]
	public uint WorldWaterFogId { get; set; }

	[Column("SurfaceType")]
	public uint SurfaceType { get; set; }

	[Column("particleFile")]
	public string ParticleFile { get; set; } = string.Empty;

	[Column("soundDirectionalAmbienceId")]
	public uint SoundDirectionalAmbienceId { get; set; }
}
