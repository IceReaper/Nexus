using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4EffectModificationRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("spell4EffectsId")]
	public uint Spell4EffectsId { get; set; }

	[Column("effectTypeEnum")]
	public uint EffectTypeEnum { get; set; }

	[Column("modificationParameterEnum")]
	public uint ModificationParameterEnum { get; set; }

	[Column("priority")]
	public uint Priority { get; set; }

	[Column("modificationTypeEnum")]
	public uint ModificationTypeEnum { get; set; }

	[Column("data00")]
	public float Data00 { get; set; }

	[Column("data01")]
	public float Data01 { get; set; }

	[Column("data02")]
	public float Data02 { get; set; }

	[Column("data03")]
	public float Data03 { get; set; }
}
