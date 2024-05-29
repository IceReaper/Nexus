using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class UnitVehicleRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("vehicleTypeEnum")]
	public uint VehicleTypeEnum { get; set; }

	[Column("numberPilots")]
	public uint NumberPilots { get; set; }

	[Column("pilotPosture00")]
	public uint PilotPosture00 { get; set; }

	[Column("pilotPosture01")]
	public uint PilotPosture01 { get; set; }

	[Column("numberPassengers")]
	public uint NumberPassengers { get; set; }

	[Column("passengerPosture00")]
	public uint PassengerPosture00 { get; set; }

	[Column("passengerPosture01")]
	public uint PassengerPosture01 { get; set; }

	[Column("passengerPosture02")]
	public uint PassengerPosture02 { get; set; }

	[Column("passengerPosture03")]
	public uint PassengerPosture03 { get; set; }

	[Column("passengerPosture04")]
	public uint PassengerPosture04 { get; set; }

	[Column("passengerPosture05")]
	public uint PassengerPosture05 { get; set; }

	[Column("numberGunners")]
	public uint NumberGunners { get; set; }

	[Column("gunnerPosture00")]
	public uint GunnerPosture00 { get; set; }

	[Column("gunnerPosture01")]
	public uint GunnerPosture01 { get; set; }

	[Column("gunnerPosture02")]
	public uint GunnerPosture02 { get; set; }

	[Column("gunnerPosture03")]
	public uint GunnerPosture03 { get; set; }

	[Column("gunnerPosture04")]
	public uint GunnerPosture04 { get; set; }

	[Column("gunnerPosture05")]
	public uint GunnerPosture05 { get; set; }

	[Column("vendorItemPrice")]
	public uint VendorItemPrice { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("localizedTextIdTooltip")]
	public uint LocalizedTextIdTooltip { get; set; }

	[Column("buttonIcon")]
	public string ButtonIcon { get; set; } = string.Empty;

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("soundEventIdTakeoff")]
	public uint SoundEventIdTakeoff { get; set; }

	[Column("soundEventIdLanding")]
	public uint SoundEventIdLanding { get; set; }

	[Column("waterSurfaceEffectIdMoving")]
	public uint WaterSurfaceEffectIdMoving { get; set; }

	[Column("waterSurfaceEffectIdStanding")]
	public uint WaterSurfaceEffectIdStanding { get; set; }

	[Column("waterSurfaceEffectIdJumpIn")]
	public uint WaterSurfaceEffectIdJumpIn { get; set; }

	[Column("waterSurfaceEffectIdJumpOut")]
	public uint WaterSurfaceEffectIdJumpOut { get; set; }
}
