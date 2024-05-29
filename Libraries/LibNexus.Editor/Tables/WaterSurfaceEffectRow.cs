using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WaterSurfaceEffectRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("emissionDelay")]
	public uint EmissionDelay { get; set; }

	[Column("worldWaterWakeIdStillWater0")]
	public uint WorldWaterWakeIdStillWater0 { get; set; }

	[Column("worldWaterWakeIdStillWater1")]
	public uint WorldWaterWakeIdStillWater1 { get; set; }

	[Column("visualEffectIdParticle0")]
	public uint VisualEffectIdParticle0 { get; set; }

	[Column("visualEffectIdParticle1")]
	public uint VisualEffectIdParticle1 { get; set; }

	[Column("particleFlags0")]
	public uint ParticleFlags0 { get; set; }

	[Column("particleFlags1")]
	public uint ParticleFlags1 { get; set; }
}
