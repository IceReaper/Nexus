using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PrerequisiteRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("prerequisiteTypeId0")]
	public uint PrerequisiteTypeId0 { get; set; }

	[Column("prerequisiteTypeId1")]
	public uint PrerequisiteTypeId1 { get; set; }

	[Column("prerequisiteTypeId2")]
	public uint PrerequisiteTypeId2 { get; set; }

	[Column("prerequisiteComparisonId0")]
	public uint PrerequisiteComparisonId0 { get; set; }

	[Column("prerequisiteComparisonId1")]
	public uint PrerequisiteComparisonId1 { get; set; }

	[Column("prerequisiteComparisonId2")]
	public uint PrerequisiteComparisonId2 { get; set; }

	[Column("objectId0")]
	public uint ObjectId0 { get; set; }

	[Column("objectId1")]
	public uint ObjectId1 { get; set; }

	[Column("objectId2")]
	public uint ObjectId2 { get; set; }

	[Column("value0")]
	public uint Value0 { get; set; }

	[Column("value1")]
	public uint Value1 { get; set; }

	[Column("value2")]
	public uint Value2 { get; set; }

	[Column("localizedTextIdFailure")]
	public uint LocalizedTextIdFailure { get; set; }
}
