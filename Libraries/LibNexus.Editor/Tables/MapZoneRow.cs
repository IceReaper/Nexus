using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MapZoneRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("mapContinentId")]
	public uint MapContinentId { get; set; }

	[Column("folder")]
	public string Folder { get; set; } = string.Empty;

	[Column("hexMinX")]
	public uint HexMinX { get; set; }

	[Column("hexMinY")]
	public uint HexMinY { get; set; }

	[Column("hexLimX")]
	public uint HexLimX { get; set; }

	[Column("hexLimY")]
	public uint HexLimY { get; set; }

	[Column("version")]
	public uint Version { get; set; }

	[Column("mapZoneIdParent")]
	public uint MapZoneIdParent { get; set; }

	[Column("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("prerequisiteIdVisibility")]
	public uint PrerequisiteIdVisibility { get; set; }

	[Column("rewardTrackId")]
	public uint RewardTrackId { get; set; }
}
