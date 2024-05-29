using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ChallengeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("challengeTypeEnum")]
	public uint ChallengeTypeEnum { get; set; }

	[Column("target")]
	public uint Target { get; set; }

	[Column("challengeFlags")]
	public uint ChallengeFlags { get; set; }

	[Column("worldZoneIdRestriction")]
	public uint WorldZoneIdRestriction { get; set; }

	[Column("triggerVolume2IdRestriction")]
	public uint TriggerVolume2IdRestriction { get; set; }

	[Column("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[Column("worldLocation2IdIndicator")]
	public uint WorldLocation2IdIndicator { get; set; }

	[Column("worldLocation2IdStartLocation")]
	public uint WorldLocation2IdStartLocation { get; set; }

	[Column("completionCount")]
	public uint CompletionCount { get; set; }

	[Column("challengeTierId00")]
	public uint ChallengeTierId00 { get; set; }

	[Column("challengeTierId01")]
	public uint ChallengeTierId01 { get; set; }

	[Column("challengeTierId02")]
	public uint ChallengeTierId02 { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdProgress")]
	public uint LocalizedTextIdProgress { get; set; }

	[Column("localizedTextIdAreaRestriction")]
	public uint LocalizedTextIdAreaRestriction { get; set; }

	[Column("localizedTextIdLocation")]
	public uint LocalizedTextIdLocation { get; set; }

	[Column("virtualItemIdDisplay")]
	public uint VirtualItemIdDisplay { get; set; }

	[Column("targetGroupIdRewardPane")]
	public uint TargetGroupIdRewardPane { get; set; }

	[Column("questDirectionIdActive")]
	public uint QuestDirectionIdActive { get; set; }

	[Column("questDirectionIdInactive")]
	public uint QuestDirectionIdInactive { get; set; }

	[Column("rewardTrackId")]
	public uint RewardTrackId { get; set; }
}
