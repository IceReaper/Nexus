using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CinematicRaceRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("cinematicId")]
	public uint CinematicId { get; set; }

	[Column("raceId")]
	public uint RaceId { get; set; }

	[Column("maleAssetPath")]
	public string MaleAssetPath { get; set; } = string.Empty;

	[Column("femaleAssetPath")]
	public string FemaleAssetPath { get; set; } = string.Empty;
}
