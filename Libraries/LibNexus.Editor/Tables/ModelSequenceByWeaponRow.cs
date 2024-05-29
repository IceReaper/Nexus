using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelSequenceByWeaponRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("modelSequenceId")]
	public uint ModelSequenceId { get; set; }

	[Column("modelSequenceId1H")]
	public uint ModelSequenceId1H { get; set; }

	[Column("modelSequenceId2H")]
	public uint ModelSequenceId2H { get; set; }

	[Column("modelSequenceId2HL")]
	public uint ModelSequenceId2Hl { get; set; }

	[Column("modelSequenceId2HGun")]
	public uint ModelSequenceId2HGun { get; set; }

	[Column("modelSequenceIdPistols")]
	public uint ModelSequenceIdPistols { get; set; }

	[Column("modelSequenceIdClaws")]
	public uint ModelSequenceIdClaws { get; set; }

	[Column("modelSequenceIdShockPaddles")]
	public uint ModelSequenceIdShockPaddles { get; set; }

	[Column("modelSequenceIdEsper")]
	public uint ModelSequenceIdEsper { get; set; }

	[Column("modelSequenceIdPsyblade")]
	public uint ModelSequenceIdPsyblade { get; set; }

	[Column("modelSequenceIdHeavygun")]
	public uint ModelSequenceIdHeavygun { get; set; }
}
