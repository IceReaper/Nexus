using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class VeteranTierRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("primeLevel")]
	public uint PrimeLevel { get; set; }

	[Column("veteranTierScalingType")]
	public uint VeteranTierScalingType { get; set; }

	[Column("unitPropertyOverrideMenace")]
	public uint UnitPropertyOverrideMenace { get; set; }
}
