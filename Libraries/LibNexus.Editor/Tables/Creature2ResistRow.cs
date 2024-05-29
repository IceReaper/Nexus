using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Creature2ResistRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("resistPhysicalMultiplier")]
	public float ResistPhysicalMultiplier { get; set; }

	[Column("resistTechMultiplier")]
	public float ResistTechMultiplier { get; set; }

	[Column("resistMagicMultiplier")]
	public float ResistMagicMultiplier { get; set; }
}
