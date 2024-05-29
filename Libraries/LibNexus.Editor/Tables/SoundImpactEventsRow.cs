using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SoundImpactEventsRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("origin")]
	public uint Origin { get; set; }

	[Column("target")]
	public uint Target { get; set; }

	[Column("qualifier")]
	public uint Qualifier { get; set; }

	[Column("event")]
	public uint Event { get; set; }
}
