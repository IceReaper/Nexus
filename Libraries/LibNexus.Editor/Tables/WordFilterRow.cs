using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WordFilterRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("filter")]
	public string Filter { get; set; } = string.Empty;

	[Column("userTextFilterClassEnum")]
	public uint UserTextFilterClassEnum { get; set; }

	[Column("deploymentRegionEnum")]
	public uint DeploymentRegionEnum { get; set; }

	[Column("languageId")]
	public uint LanguageId { get; set; }

	[Column("wordFilterTypeEnum")]
	public uint WordFilterTypeEnum { get; set; }
}
