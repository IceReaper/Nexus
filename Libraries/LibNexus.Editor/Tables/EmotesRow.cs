using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class EmotesRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdNoArgToAll")]
	public uint LocalizedTextIdNoArgToAll { get; set; }

	[Column("localizedTextIdNoArgToSelf")]
	public uint LocalizedTextIdNoArgToSelf { get; set; }

	[Column("NoArgAnim")]
	public uint NoArgAnim { get; set; }

	[Column("localizedTextIdArgToAll")]
	public uint LocalizedTextIdArgToAll { get; set; }

	[Column("localizedTextIdArgToArg")]
	public uint LocalizedTextIdArgToArg { get; set; }

	[Column("localizedTextIdArgToSelf")]
	public uint LocalizedTextIdArgToSelf { get; set; }

	[Column("ArgAnim")]
	public uint ArgAnim { get; set; }

	[Column("localizedTextIdSelfToAll")]
	public uint LocalizedTextIdSelfToAll { get; set; }

	[Column("localizedTextIdSelfToSelf")]
	public uint LocalizedTextIdSelfToSelf { get; set; }

	[Column("SelfAnim")]
	public uint SelfAnim { get; set; }

	[Column("SheathWeapons")]
	public bool SheathWeapons { get; set; }

	[Column("TurnToFace")]
	public bool TurnToFace { get; set; }

	[Column("TextReplaceable")]
	public bool TextReplaceable { get; set; }

	[Column("ChangesStandState")]
	public bool ChangesStandState { get; set; }

	[Column("StandState")]
	public uint StandState { get; set; }

	[Column("localizedTextIdCommand")]
	public uint LocalizedTextIdCommand { get; set; }

	[Column("localizedTextIdNotFoundToAll")]
	public uint LocalizedTextIdNotFoundToAll { get; set; }

	[Column("localizedTextIdNotFoundToSelf")]
	public uint LocalizedTextIdNotFoundToSelf { get; set; }

	[Column("NotFoundAnim")]
	public uint NotFoundAnim { get; set; }

	[Column("TextReplaceAnim")]
	public uint TextReplaceAnim { get; set; }

	[Column("modelSequenceIdStandState")]
	public uint ModelSequenceIdStandState { get; set; }

	[Column("visualEffectId")]
	public uint VisualEffectId { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("universalCommand00")]
	public string UniversalCommand00 { get; set; } = string.Empty;

	[Column("universalCommand01")]
	public string UniversalCommand01 { get; set; } = string.Empty;
}
