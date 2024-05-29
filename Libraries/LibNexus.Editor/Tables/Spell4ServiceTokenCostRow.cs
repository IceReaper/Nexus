using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4ServiceTokenCostRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("spell4Id")]
	public uint Spell4Id { get; set; }

	[Column("serviceTokenCost")]
	public uint ServiceTokenCost { get; set; }
}
