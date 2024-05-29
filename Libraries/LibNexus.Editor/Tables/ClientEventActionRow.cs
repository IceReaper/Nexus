using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ClientEventActionRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("actionTypeEnum")]
	public uint ActionTypeEnum { get; set; }

	[Column("actionData00")]
	public uint ActionData00 { get; set; }

	[Column("actionData01")]
	public uint ActionData01 { get; set; }

	[Column("localizedTextIdSubZoneName")]
	public uint LocalizedTextIdSubZoneName { get; set; }
}
