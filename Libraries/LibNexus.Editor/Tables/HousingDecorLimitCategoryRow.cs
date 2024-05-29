using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingDecorLimitCategoryRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("decorLimit")]
	public uint DecorLimit { get; set; }
}
