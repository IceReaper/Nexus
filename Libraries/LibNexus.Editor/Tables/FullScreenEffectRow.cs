using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class FullScreenEffectRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("description")]
	public string Description { get; set; } = string.Empty;

	[Column("texturePath")]
	public string TexturePath { get; set; } = string.Empty;

	[Column("modelPath")]
	public string ModelPath { get; set; } = string.Empty;

	[Column("priority")]
	public uint Priority { get; set; }

	[Column("fullScreenEffectTypeEnum")]
	public uint FullScreenEffectTypeEnum { get; set; }

	[Column("alphaMinStart")]
	public float AlphaMinStart { get; set; }

	[Column("alphaMinEnd")]
	public float AlphaMinEnd { get; set; }

	[Column("alphaStart")]
	public float AlphaStart { get; set; }

	[Column("alphaEnd")]
	public float AlphaEnd { get; set; }

	[Column("hzStart")]
	public float HzStart { get; set; }

	[Column("hzEnd")]
	public float HzEnd { get; set; }

	[Column("saturationStart")]
	public float SaturationStart { get; set; }

	[Column("saturationEnd")]
	public float SaturationEnd { get; set; }
}
