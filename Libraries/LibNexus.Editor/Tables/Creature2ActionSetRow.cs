using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Creature2ActionSetRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("description")]
	public string Description { get; set; } = string.Empty;

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }
}
