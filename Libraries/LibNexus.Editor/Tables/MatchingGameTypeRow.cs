using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MatchingGameTypeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[Column("matchTypeEnum")]
	public uint MatchTypeEnum { get; set; }

	[Column("matchingGameTypeEnumFlags")]
	public uint MatchingGameTypeEnumFlags { get; set; }

	[Column("teamSize")]
	public uint TeamSize { get; set; }

	[Column("minLevel")]
	public uint MinLevel { get; set; }

	[Column("maxLevel")]
	public uint MaxLevel { get; set; }

	[Column("preparationTimeMS")]
	public uint PreparationTimeMs { get; set; }

	[Column("matchTimeMS")]
	public uint MatchTimeMs { get; set; }

	[Column("matchingRulesEnum")]
	public uint MatchingRulesEnum { get; set; }

	[Column("matchingRulesData00")]
	public uint MatchingRulesData00 { get; set; }

	[Column("matchingRulesData01")]
	public uint MatchingRulesData01 { get; set; }

	[Column("targetItemLevel")]
	public uint TargetItemLevel { get; set; }
}
