using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class GuildPerkRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[Column("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[Column("luaSprite")]
	public string LuaSprite { get; set; } = string.Empty;

	[Column("luaName")]
	public string LuaName { get; set; } = string.Empty;

	[Column("purchaseInfluenceCost")]
	public uint PurchaseInfluenceCost { get; set; }

	[Column("activateInfluenceCost")]
	public uint ActivateInfluenceCost { get; set; }

	[Column("spell4IdActivate")]
	public uint Spell4IdActivate { get; set; }

	[Column("guildPerkIdRequired00")]
	public uint GuildPerkIdRequired00 { get; set; }

	[Column("guildPerkIdRequired01")]
	public uint GuildPerkIdRequired01 { get; set; }

	[Column("guildPerkIdRequired02")]
	public uint GuildPerkIdRequired02 { get; set; }

	[Column("achievementIdRequired")]
	public uint AchievementIdRequired { get; set; }
}
