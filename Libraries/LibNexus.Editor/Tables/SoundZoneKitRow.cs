using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SoundZoneKitRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("soundZoneKitIdParent")]
	public uint SoundZoneKitIdParent { get; set; }

	[Column("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[Column("inheritFlags")]
	public uint InheritFlags { get; set; }

	[Column("propertyFlags")]
	public uint PropertyFlags { get; set; }

	[Column("soundMusicSetId")]
	public uint SoundMusicSetId { get; set; }

	[Column("soundEventIdIntro")]
	public uint SoundEventIdIntro { get; set; }

	[Column("introReplayWait")]
	public float IntroReplayWait { get; set; }

	[Column("soundEventIdMusicMood")]
	public uint SoundEventIdMusicMood { get; set; }

	[Column("soundEventIdAmbientDay")]
	public uint SoundEventIdAmbientDay { get; set; }

	[Column("soundEventIdAmbientNight")]
	public uint SoundEventIdAmbientNight { get; set; }

	[Column("soundEventIdAmbientUnderwater")]
	public uint SoundEventIdAmbientUnderwater { get; set; }

	[Column("soundEventIdAmbientStop")]
	public uint SoundEventIdAmbientStop { get; set; }

	[Column("soundEventIdAmbientPreStopOverride")]
	public uint SoundEventIdAmbientPreStopOverride { get; set; }

	[Column("soundEnvironmentId00")]
	public uint SoundEnvironmentId00 { get; set; }

	[Column("soundEnvironmentId01")]
	public uint SoundEnvironmentId01 { get; set; }

	[Column("environmentDry")]
	public float EnvironmentDry { get; set; }

	[Column("environmentWet00")]
	public float EnvironmentWet00 { get; set; }

	[Column("environmentWet01")]
	public float EnvironmentWet01 { get; set; }
}
