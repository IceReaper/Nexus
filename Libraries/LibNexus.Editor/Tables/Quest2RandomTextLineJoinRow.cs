using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Quest2RandomTextLineJoinRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("quest2Id")]
	public uint Quest2Id { get; set; }

	[Column("questVOTextType")]
	public uint QuestVoTextType { get; set; }

	[Column("randomTextLineId")]
	public uint RandomTextLineId { get; set; }
}
