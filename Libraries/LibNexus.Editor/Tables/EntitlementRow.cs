using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class EntitlementRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("maxCount")]
	public uint MaxCount { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("spell4IdPersistentBuff")]
	public uint Spell4IdPersistentBuff { get; set; }

	[Column("characterTitleId")]
	public uint CharacterTitleId { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[Column("buttonIcon")]
	public string ButtonIcon { get; set; } = string.Empty;
}
