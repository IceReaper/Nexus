using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class GenericMapNodeRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("genericMapId")]
	public uint GenericMapId { get; set; }

	[Column("worldLocation2Id")]
	public uint WorldLocation2Id { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[Column("spritePath")]
	public string SpritePath { get; set; } = string.Empty;

	[Column("genericMapNodeTypeEnum")]
	public uint GenericMapNodeTypeEnum { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }
}
