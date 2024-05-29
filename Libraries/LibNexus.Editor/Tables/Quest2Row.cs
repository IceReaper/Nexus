using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Quest2Row
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[Column("localizedTextIdText")]
	public uint LocalizedTextIdText { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("conLevel")]
	public uint ConLevel { get; set; }

	[Column("type")]
	public uint Type { get; set; }

	[Column("preq_level")]
	public uint PreqLevel { get; set; }

	[Column("preq_flags")]
	public uint PreqFlags { get; set; }

	[Column("preq_quest0")]
	public uint PreqQuest0 { get; set; }

	[Column("preq_quest01")]
	public uint PreqQuest01 { get; set; }

	[Column("preq_quest02")]
	public uint PreqQuest02 { get; set; }

	[Column("preq_race")]
	public uint PreqRace { get; set; }

	[Column("preq_item")]
	public uint PreqItem { get; set; }

	[Column("questPlayerFactionEnum")]
	public uint QuestPlayerFactionEnum { get; set; }

	[Column("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[Column("localizedTextIdCompletionOverride")]
	public uint LocalizedTextIdCompletionOverride { get; set; }

	[Column("reward_xpOverride")]
	public uint RewardXpOverride { get; set; }

	[Column("reward_cashOverride")]
	public uint RewardCashOverride { get; set; }

	[Column("pushed_itemId0")]
	public uint PushedItemId0 { get; set; }

	[Column("pushed_itemId01")]
	public uint PushedItemId01 { get; set; }

	[Column("pushed_itemId02")]
	public uint PushedItemId02 { get; set; }

	[Column("pushed_itemId03")]
	public uint PushedItemId03 { get; set; }

	[Column("pushed_itemId04")]
	public uint PushedItemId04 { get; set; }

	[Column("pushed_itemId05")]
	public uint PushedItemId05 { get; set; }

	[Column("pushed_itemCount0")]
	public uint PushedItemCount0 { get; set; }

	[Column("pushed_itemCount01")]
	public uint PushedItemCount01 { get; set; }

	[Column("pushed_itemCount02")]
	public uint PushedItemCount02 { get; set; }

	[Column("pushed_itemCount03")]
	public uint PushedItemCount03 { get; set; }

	[Column("pushed_itemCount04")]
	public uint PushedItemCount04 { get; set; }

	[Column("pushed_itemCount05")]
	public uint PushedItemCount05 { get; set; }

	[Column("objective0")]
	public uint Objective0 { get; set; }

	[Column("objective01")]
	public uint Objective01 { get; set; }

	[Column("objective02")]
	public uint Objective02 { get; set; }

	[Column("objective03")]
	public uint Objective03 { get; set; }

	[Column("objective04")]
	public uint Objective04 { get; set; }

	[Column("objective05")]
	public uint Objective05 { get; set; }

	[Column("localizedTextIdGiverTextUnknown")]
	public uint LocalizedTextIdGiverTextUnknown { get; set; }

	[Column("localizedTextIdGiverTextAccepted")]
	public uint LocalizedTextIdGiverTextAccepted { get; set; }

	[Column("localizedTextIdReceiverTextAccepted")]
	public uint LocalizedTextIdReceiverTextAccepted { get; set; }

	[Column("localizedTextIdReceiverTextAchieved")]
	public uint LocalizedTextIdReceiverTextAchieved { get; set; }

	[Column("localizedTextIdGiverSayAccepted")]
	public uint LocalizedTextIdGiverSayAccepted { get; set; }

	[Column("localizedTextIdReceiverSayCompleted")]
	public uint LocalizedTextIdReceiverSayCompleted { get; set; }

	[Column("preq_class")]
	public uint PreqClass { get; set; }

	[Column("groupId")]
	public uint GroupId { get; set; }

	[Column("factionIdPreq0")]
	public uint FactionIdPreq0 { get; set; }

	[Column("factionIdPreq01")]
	public uint FactionIdPreq01 { get; set; }

	[Column("factionIdPreq02")]
	public uint FactionIdPreq02 { get; set; }

	[Column("factionLevelPreq0")]
	public uint FactionLevelPreq0 { get; set; }

	[Column("factionLevelPreq01")]
	public uint FactionLevelPreq01 { get; set; }

	[Column("factionLevelPreq02")]
	public uint FactionLevelPreq02 { get; set; }

	[Column("factionLevelCompPreq0")]
	public bool FactionLevelCompPreq0 { get; set; }

	[Column("factionLevelCompPreq01")]
	public bool FactionLevelCompPreq01 { get; set; }

	[Column("factionLevelCompPreq02")]
	public bool FactionLevelCompPreq02 { get; set; }

	[Column("questIdExclusionPreq0")]
	public uint QuestIdExclusionPreq0 { get; set; }

	[Column("questIdExclusionPreq1")]
	public uint QuestIdExclusionPreq1 { get; set; }

	[Column("questIdExclusionPreq2")]
	public uint QuestIdExclusionPreq2 { get; set; }

	[Column("localizedTextIdAcceptResponse")]
	public uint LocalizedTextIdAcceptResponse { get; set; }

	[Column("localizedTextIdCompleteResponse")]
	public uint LocalizedTextIdCompleteResponse { get; set; }

	[Column("WorldLocation2IdReceiver")]
	public uint WorldLocation2IdReceiver { get; set; }

	[Column("worldLocation2IdAltReceiver00")]
	public uint WorldLocation2IdAltReceiver00 { get; set; }

	[Column("worldLocation2IdAltReceiver01")]
	public uint WorldLocation2IdAltReceiver01 { get; set; }

	[Column("worldLocation2IdAltReceiver02")]
	public uint WorldLocation2IdAltReceiver02 { get; set; }

	[Column("prerequisiteIdAltReceiver00")]
	public uint PrerequisiteIdAltReceiver00 { get; set; }

	[Column("prerequisiteIdAltReceiver01")]
	public uint PrerequisiteIdAltReceiver01 { get; set; }

	[Column("prerequisiteIdAltReceiver02")]
	public uint PrerequisiteIdAltReceiver02 { get; set; }

	[Column("questDirectionIdAltReceiver00")]
	public uint QuestDirectionIdAltReceiver00 { get; set; }

	[Column("questDirectionIdAltReceiver01")]
	public uint QuestDirectionIdAltReceiver01 { get; set; }

	[Column("questDirectionIdAltReceiver02")]
	public uint QuestDirectionIdAltReceiver02 { get; set; }

	[Column("localizedTextIdCompletedSummary")]
	public uint LocalizedTextIdCompletedSummary { get; set; }

	[Column("localizedTextIdGiverIncompleteResponse")]
	public uint LocalizedTextIdGiverIncompleteResponse { get; set; }

	[Column("localizedTextIdReceiverIncompleteResponse")]
	public uint LocalizedTextIdReceiverIncompleteResponse { get; set; }

	[Column("quest2DifficultyId")]
	public uint Quest2DifficultyId { get; set; }

	[Column("maxTimeAllowedMS")]
	public uint MaxTimeAllowedMs { get; set; }

	[Column("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[Column("questShareEnum")]
	public uint QuestShareEnum { get; set; }

	[Column("subMissionPathType")]
	public uint SubMissionPathType { get; set; }

	[Column("localizedTextIdCompletedObjectiveShort")]
	public uint LocalizedTextIdCompletedObjectiveShort { get; set; }

	[Column("quest2SubTypeId")]
	public uint Quest2SubTypeId { get; set; }

	[Column("localizedTextIdMoreInfoSay00")]
	public uint LocalizedTextIdMoreInfoSay00 { get; set; }

	[Column("localizedTextIdMoreInfoSay01")]
	public uint LocalizedTextIdMoreInfoSay01 { get; set; }

	[Column("localizedTextIdMoreInfoSay02")]
	public uint LocalizedTextIdMoreInfoSay02 { get; set; }

	[Column("localizedTextIdMoreInfoSay03")]
	public uint LocalizedTextIdMoreInfoSay03 { get; set; }

	[Column("localizedTextIdMoreInfoSay04")]
	public uint LocalizedTextIdMoreInfoSay04 { get; set; }

	[Column("localizedTextIdMoreInfoText00")]
	public uint LocalizedTextIdMoreInfoText00 { get; set; }

	[Column("localizedTextIdMoreInfoText01")]
	public uint LocalizedTextIdMoreInfoText01 { get; set; }

	[Column("localizedTextIdMoreInfoText02")]
	public uint LocalizedTextIdMoreInfoText02 { get; set; }

	[Column("localizedTextIdMoreInfoText03")]
	public uint LocalizedTextIdMoreInfoText03 { get; set; }

	[Column("localizedTextIdMoreInfoText04")]
	public uint LocalizedTextIdMoreInfoText04 { get; set; }

	[Column("virtualItemIdPushed00")]
	public uint VirtualItemIdPushed00 { get; set; }

	[Column("virtualItemIdPushed01")]
	public uint VirtualItemIdPushed01 { get; set; }

	[Column("virtualItemIdPushed02")]
	public uint VirtualItemIdPushed02 { get; set; }

	[Column("virtualItemIdPushed03")]
	public uint VirtualItemIdPushed03 { get; set; }

	[Column("virtualItemPushedCount00")]
	public uint VirtualItemPushedCount00 { get; set; }

	[Column("virtualItemPushedCount01")]
	public uint VirtualItemPushedCount01 { get; set; }

	[Column("virtualItemPushedCount02")]
	public uint VirtualItemPushedCount02 { get; set; }

	[Column("virtualItemPushedCount03")]
	public uint VirtualItemPushedCount03 { get; set; }

	[Column("virtualItemPushedObjectiveFlagsEnum00")]
	public uint VirtualItemPushedObjectiveFlagsEnum00 { get; set; }

	[Column("virtualItemPushedObjectiveFlagsEnum01")]
	public uint VirtualItemPushedObjectiveFlagsEnum01 { get; set; }

	[Column("virtualItemPushedObjectiveFlagsEnum02")]
	public uint VirtualItemPushedObjectiveFlagsEnum02 { get; set; }

	[Column("virtualItemPushedObjectiveFlagsEnum03")]
	public uint VirtualItemPushedObjectiveFlagsEnum03 { get; set; }

	[Column("questDirectionIdCompletion")]
	public uint QuestDirectionIdCompletion { get; set; }

	[Column("faction2IdRewardReputation00")]
	public uint Faction2IdRewardReputation00 { get; set; }

	[Column("faction2IdRewardReputation01")]
	public uint Faction2IdRewardReputation01 { get; set; }

	[Column("rewardReputationOverride00")]
	public float RewardReputationOverride00 { get; set; }

	[Column("rewardReputationOverride01")]
	public float RewardReputationOverride01 { get; set; }

	[Column("questCategoryId")]
	public uint QuestCategoryId { get; set; }

	[Column("localizedTextIdGiverSayDecline")]
	public uint LocalizedTextIdGiverSayDecline { get; set; }

	[Column("periodicQuestGroupId")]
	public uint PeriodicQuestGroupId { get; set; }

	[Column("periodicQuestWeight")]
	public uint PeriodicQuestWeight { get; set; }

	[Column("questRepeatPeriodEnum")]
	public uint QuestRepeatPeriodEnum { get; set; }

	[Column("questContentFinderTypeEnum")]
	public uint QuestContentFinderTypeEnum { get; set; }

	[Column("groupSize")]
	public uint GroupSize { get; set; }
}
