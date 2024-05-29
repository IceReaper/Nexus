using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillSchematic2Row
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[Column("tradeSkillId")]
	public uint TradeSkillId { get; set; }

	[Column("item2IdOutput")]
	public uint Item2IdOutput { get; set; }

	[Column("item2IdOutputFail")]
	public uint Item2IdOutputFail { get; set; }

	[Column("outputCount")]
	public uint OutputCount { get; set; }

	[Column("lootId")]
	public uint LootId { get; set; }

	[Column("tier")]
	public uint Tier { get; set; }

	[Column("flags")]
	public uint Flags { get; set; }

	[Column("item2IdMaterial00")]
	public uint Item2IdMaterial00 { get; set; }

	[Column("item2IdMaterial01")]
	public uint Item2IdMaterial01 { get; set; }

	[Column("item2IdMaterial02")]
	public uint Item2IdMaterial02 { get; set; }

	[Column("item2IdMaterial03")]
	public uint Item2IdMaterial03 { get; set; }

	[Column("item2IdMaterial04")]
	public uint Item2IdMaterial04 { get; set; }

	[Column("materialCost00")]
	public uint MaterialCost00 { get; set; }

	[Column("materialCost01")]
	public uint MaterialCost01 { get; set; }

	[Column("materialCost02")]
	public uint MaterialCost02 { get; set; }

	[Column("materialCost03")]
	public uint MaterialCost03 { get; set; }

	[Column("materialCost04")]
	public uint MaterialCost04 { get; set; }

	[Column("tradeskillSchematic2IdParent")]
	public uint TradeskillSchematic2IdParent { get; set; }

	[Column("vectorX")]
	public float VectorX { get; set; }

	[Column("vectorY")]
	public float VectorY { get; set; }

	[Column("radius")]
	public float Radius { get; set; }

	[Column("critRadius")]
	public float CritRadius { get; set; }

	[Column("item2IdOutputCrit")]
	public uint Item2IdOutputCrit { get; set; }

	[Column("outputCountCritBonus")]
	public uint OutputCountCritBonus { get; set; }

	[Column("priority")]
	public uint Priority { get; set; }

	[Column("maxAdditives")]
	public uint MaxAdditives { get; set; }

	[Column("discoverableQuadrant")]
	public uint DiscoverableQuadrant { get; set; }

	[Column("discoverableRadius")]
	public float DiscoverableRadius { get; set; }

	[Column("discoverableAngle")]
	public float DiscoverableAngle { get; set; }

	[Column("tradeskillCatalystOrderingId")]
	public uint TradeskillCatalystOrderingId { get; set; }
}
