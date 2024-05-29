using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillProficiencyRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("proficiencyFlagEnum")]
	public uint ProficiencyFlagEnum { get; set; }
}
