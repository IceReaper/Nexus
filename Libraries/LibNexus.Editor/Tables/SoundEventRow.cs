using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SoundEventRow
{
	[Column("id")]
	public uint Id { get; set; }

	[Column("name")]
	public string Name { get; set; } = string.Empty;

	[Column("hash")]
	public uint Hash { get; set; }

	[Column("radius")]
	public float Radius { get; set; }

	[Column("soundBankId00")]
	public uint SoundBankId00 { get; set; }

	[Column("soundBankId01")]
	public uint SoundBankId01 { get; set; }

	[Column("soundBankId02")]
	public uint SoundBankId02 { get; set; }

	[Column("soundBankId03")]
	public uint SoundBankId03 { get; set; }

	[Column("soundBankId04")]
	public uint SoundBankId04 { get; set; }

	[Column("soundBankId05")]
	public uint SoundBankId05 { get; set; }

	[Column("soundBankId06")]
	public uint SoundBankId06 { get; set; }

	[Column("soundBankId07")]
	public uint SoundBankId07 { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("limitPriority")]
	public uint LimitPriority { get; set; }
}
