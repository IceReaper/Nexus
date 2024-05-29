using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventObjectiveBombDeploymentRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("creature2IdBomb")]
	public uint Creature2IdBomb { get; set; }

	[Column("spell4IdCarrying")]
	public uint Spell4IdCarrying { get; set; }
}
