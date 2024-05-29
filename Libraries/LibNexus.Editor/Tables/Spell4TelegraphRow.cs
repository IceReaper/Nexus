using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4TelegraphRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("spell4Id")]
	public uint Spell4Id { get; set; }

	[Column("telegraphDamageId")]
	public uint TelegraphDamageId { get; set; }
}
