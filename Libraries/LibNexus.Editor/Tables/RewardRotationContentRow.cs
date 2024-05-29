using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RewardRotationContentRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("contentTypeEnum")]
	public uint ContentTypeEnum { get; set; }
}
