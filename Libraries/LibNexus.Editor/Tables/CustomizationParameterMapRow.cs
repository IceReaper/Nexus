using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CustomizationParameterMapRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("raceId")]
	public uint RaceId { get; set; }

	[Column("genderEnum")]
	public uint GenderEnum { get; set; }

	[Column("modelBoneId")]
	public uint ModelBoneId { get; set; }

	[Column("customizationParameterId")]
	public uint CustomizationParameterId { get; set; }

	[Column("dataOrder")]
	public uint DataOrder { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }
}
