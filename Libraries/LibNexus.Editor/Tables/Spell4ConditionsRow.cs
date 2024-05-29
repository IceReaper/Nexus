using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4ConditionsRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("conditionMask")]
	public uint ConditionMask { get; set; }

	[Column("conditionValue")]
	public uint ConditionValue { get; set; }
}
