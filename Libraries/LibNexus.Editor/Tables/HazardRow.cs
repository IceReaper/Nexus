using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HazardRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdTooltip")]
	public uint LocalizedTextIdTooltip { get; set; }

	[Column("meterChangeRate")]
	public float MeterChangeRate { get; set; }

	[Column("meterMaxValue")]
	public uint MeterMaxValue { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("hazardTypeEnum")]
	public uint HazardTypeEnum { get; set; }

	[Column("spell4IdDamage")]
	public uint Spell4IdDamage { get; set; }

	[Column("minDistanceToUnit")]
	public float MinDistanceToUnit { get; set; }

	[Column("meterThreshold00")]
	public float MeterThreshold00 { get; set; }

	[Column("meterThreshold01")]
	public float MeterThreshold01 { get; set; }

	[Column("meterThreshold02")]
	public float MeterThreshold02 { get; set; }

	[Column("spell4IdThresholdProc00")]
	public uint Spell4IdThresholdProc00 { get; set; }

	[Column("spell4IdThresholdProc01")]
	public uint Spell4IdThresholdProc01 { get; set; }

	[Column("spell4IdThresholdProc02")]
	public uint Spell4IdThresholdProc02 { get; set; }
}
