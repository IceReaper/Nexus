using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PeriodicQuestGroupRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("periodicQuestSetId")]
	public uint PeriodicQuestSetId { get; set; }

	[Column("periodicQuestsOffered")]
	public uint PeriodicQuestsOffered { get; set; }

	[Column("maxPeriodicQuestsAllowed")]
	public uint MaxPeriodicQuestsAllowed { get; set; }

	[Column("weight")]
	public uint Weight { get; set; }

	[Column("contractTypeEnum")]
	public uint ContractTypeEnum { get; set; }

	[Column("contractQualityEnum")]
	public uint ContractQualityEnum { get; set; }
}
