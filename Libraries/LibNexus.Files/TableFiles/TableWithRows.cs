using LibNexus.Core.Extensions;
using System.Reflection;

namespace LibNexus.Files.TableFiles;

public class TableWithRows<T> : Table
{
	public Dictionary<uint, T?> Rows { get; } = [];

	public TableWithRows(Stream stream)
		: base(stream)
	{
		Data.Position = (long)(Header.RowsOffset + Header.Rows * Header.RowLength);

		var strings = new Dictionary<ulong, string>();

		while ((ulong)Data.Position < Header.RowsOffset + Header.RowsLength)
			strings.Add((ulong)Data.Position - Header.RowsOffset, Data.ReadWideString());

		stream.SkipPadding(16);

		FileFormatException.ThrowIf<Table>(nameof(Header.IdMapOffset), Header.IdMapOffset != 0 && (ulong)Data.Position != Header.IdMapOffset);
		Data.Position = (long)Header.RowsOffset;

		var properties = typeof(T).GetProperties()
			.ToDictionary(
				static property => property,
				static property => property.GetCustomAttribute<TableColumnAttribute>() ?? throw new FileFormatException(typeof(T), property.Name)
			);

		var rows = new List<T>();

		for (var i = 0U; i < Header.Rows; i++)
		{
			// TODO if we can properly calculate the padding, we can skip the calculation for performance reasons!
			rows.Add(ReadRow(properties, strings, out var rowLength));
			Data.ReadBytes(Header.RowLength - rowLength); // TODO Not empty on TradeskillTier ?! TODO does this align to any Padding logic?
		}

		Data.Position = (long)Header.IdMapOffset;

		for (var i = 0U; i < Header.AutoIncrement; i++)
		{
			var id = Data.ReadUInt32();

			Rows.Add(i, id == uint.MaxValue ? default : rows[(int)id]);
		}

		stream.SkipPadding(16);

		FileFormatException.ThrowIf<Table>(nameof(Data), Data.Position != Data.Length);
	}

	private T ReadRow(Dictionary<PropertyInfo, TableColumnAttribute> properties, Dictionary<ulong, string> strings, out ulong rowLength)
	{
		var row = Activator.CreateInstance<T>();
		rowLength = 0;

		foreach (var column in Columns)
		{
			var property = properties.FirstOrDefault(entry => entry.Value.Name == column.Name).Key ?? throw new FileFormatException(typeof(T), column.Name);

			object value;

			switch (column.Type)
			{
				case TableColumnType.Uint:
					value = Data.ReadUInt32();
					rowLength += 4;

					break;

				case TableColumnType.Float:
					value = Data.ReadSingle();
					rowLength += 4;

					break;

				case TableColumnType.Bool:
					value = Data.ReadUInt32() != 0;
					rowLength += 4;

					break;

				case TableColumnType.Ulong:
					value = Data.ReadUInt64();
					rowLength += 8;

					break;

				case TableColumnType.String:
				{
					var offsetOrZero = Data.ReadUInt32();
					var textOffset = offsetOrZero != 0 ? offsetOrZero : Data.ReadUInt32();
					var unk1 = Data.ReadUInt32();

					rowLength += (ulong)(offsetOrZero != 0 ? 8 : 12);
					value = strings[textOffset];
					FileFormatException.ThrowIf<Table>(nameof(unk1), unk1 != 0);

					break;
				}

				default:
					throw new FileFormatException(typeof(T), nameof(column.Type));
			}

			property.SetValue(row, value);
		}

		return row;
	}
}
