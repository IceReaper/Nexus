using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class LocalizedTextRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("soundEventId")]
	public uint SoundEventId { get; set; }

	[Column("soundEventIdFemale")]
	public uint SoundEventIdFemale { get; set; }

	[Column("version")]
	public uint Version { get; set; }

	[Column("unitVoiceTypeId")]
	public uint UnitVoiceTypeId { get; set; }

	[Column("stringContextEnum")]
	public uint StringContextEnum { get; set; }

	[Column("soundAvailabilityFlagFemale")]
	public uint SoundAvailabilityFlagFemale { get; set; }
}
