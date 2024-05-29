using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class GenericUnlockEntryRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[Column("spriteIcon")]
	public string SpriteIcon { get; set; } = string.Empty;

	[Column("spritePreview")]
	public string SpritePreview { get; set; } = string.Empty;

	[Column("genericUnlockTypeEnum")]
	public uint GenericUnlockTypeEnum { get; set; }

	[Column("unlockObject")]
	public uint UnlockObject { get; set; }
}
