using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldWaterEnvironmentRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("LandMapPath")]
	public string LandMapPath { get; set; } = string.Empty;
}
