using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventVoteRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[Column("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[Column("localizedTextIdOption00")]
	public uint LocalizedTextIdOption00 { get; set; }

	[Column("localizedTextIdOption01")]
	public uint LocalizedTextIdOption01 { get; set; }

	[Column("localizedTextIdOption02")]
	public uint LocalizedTextIdOption02 { get; set; }

	[Column("localizedTextIdOption03")]
	public uint LocalizedTextIdOption03 { get; set; }

	[Column("localizedTextIdOption04")]
	public uint LocalizedTextIdOption04 { get; set; }

	[Column("localizedTextIdLabel00")]
	public uint LocalizedTextIdLabel00 { get; set; }

	[Column("localizedTextIdLabel01")]
	public uint LocalizedTextIdLabel01 { get; set; }

	[Column("localizedTextIdLabel02")]
	public uint LocalizedTextIdLabel02 { get; set; }

	[Column("localizedTextIdLabel03")]
	public uint LocalizedTextIdLabel03 { get; set; }

	[Column("localizedTextIdLabel04")]
	public uint LocalizedTextIdLabel04 { get; set; }

	[Column("durationMS")]
	public uint DurationMs { get; set; }

	[Column("assetPathSprite")]
	public string AssetPathSprite { get; set; } = string.Empty;
}
