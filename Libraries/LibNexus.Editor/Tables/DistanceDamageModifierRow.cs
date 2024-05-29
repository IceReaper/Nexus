using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class DistanceDamageModifierRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("distancePercent00")]
	public float DistancePercent00 { get; set; }

	[Column("distancePercent01")]
	public float DistancePercent01 { get; set; }

	[Column("distancePercent02")]
	public float DistancePercent02 { get; set; }

	[Column("distancePercent03")]
	public float DistancePercent03 { get; set; }

	[Column("distancePercent04")]
	public float DistancePercent04 { get; set; }

	[Column("damageModifier00")]
	public float DamageModifier00 { get; set; }

	[Column("damageModifier01")]
	public float DamageModifier01 { get; set; }

	[Column("damageModifier02")]
	public float DamageModifier02 { get; set; }

	[Column("damageModifier03")]
	public float DamageModifier03 { get; set; }

	[Column("damageModifier04")]
	public float DamageModifier04 { get; set; }
}
