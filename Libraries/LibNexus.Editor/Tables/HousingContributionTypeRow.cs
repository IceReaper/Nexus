using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingContributionTypeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("description")]
	public string Description { get; set; } = string.Empty;

	[Column("enumName")]
	public string EnumName { get; set; } = string.Empty;
}
