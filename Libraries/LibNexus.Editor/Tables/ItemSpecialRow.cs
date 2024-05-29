using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemSpecialRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("prerequisiteIdGeneric00")]
	public uint PrerequisiteIdGeneric00 { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("spell4IdOnEquip")]
	public uint Spell4IdOnEquip { get; set; }

	[Column("spell4IdOnActivate")]
	public uint Spell4IdOnActivate { get; set; }
}
