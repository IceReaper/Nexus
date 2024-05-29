using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class LanguageRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("languageTag")]
	public string LanguageTag { get; set; } = string.Empty;

	[Column("clientLanguageTag")]
	public string ClientLanguageTag { get; set; } = string.Empty;

	[Column("soundAvailabilityIndexFemale")]
	public uint SoundAvailabilityIndexFemale { get; set; }
}
