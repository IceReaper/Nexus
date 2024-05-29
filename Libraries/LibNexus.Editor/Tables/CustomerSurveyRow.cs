using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CustomerSurveyRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("customerSurveyTypeEnum")]
	public uint CustomerSurveyTypeEnum { get; set; }

	[Column("localizedTextIdOverrideTitle")]
	public uint LocalizedTextIdOverrideTitle { get; set; }

	[Column("localizedTextIdQuestion00")]
	public uint LocalizedTextIdQuestion00 { get; set; }

	[Column("localizedTextIdQuestion01")]
	public uint LocalizedTextIdQuestion01 { get; set; }

	[Column("localizedTextIdQuestion02")]
	public uint LocalizedTextIdQuestion02 { get; set; }
}
