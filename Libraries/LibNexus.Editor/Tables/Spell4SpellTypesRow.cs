using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4SpellTypesRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("typeName")]
	public string TypeName { get; set; } = string.Empty;

	[Column("enumName")]
	public string EnumName { get; set; } = string.Empty;
}
