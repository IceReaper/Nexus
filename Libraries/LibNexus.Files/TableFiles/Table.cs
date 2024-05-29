using LibNexus.Core.Extensions;
using System.Reflection;

namespace LibNexus.Files.TableFiles;

public class Table<T> : TableBase
{
	public Dictionary<uint, T?> Rows { get; } = [];

	public Table(Stream stream)
		: base(stream)
	{
		if (Header.RowsOffset == 0)
			return;

		var rowsPosition = ContentStart + Header.RowsOffset;

		if ((ulong)Stream.Position != rowsPosition)
			throw new Exception("Table: Invalid rows offset");

		Stream.Position += (long)(Header.Rows * Header.RowLength);

		var strings = new Dictionary<ulong, string>();

		while ((ulong)Stream.Position < rowsPosition + Header.RowsLength)
			strings.Add((ulong)Stream.Position - rowsPosition, Stream.ReadWideString());

		SkipPadding();

		var idMapPosition = ContentStart + Header.IdMapOffset;

		if ((ulong)Stream.Position != idMapPosition)
			throw new Exception("Table: Invalid id map offset");

		Stream.Position = (long)rowsPosition;

		var properties = typeof(T).GetProperties()
			.ToDictionary(
				static property => property,
				static property => property.GetCustomAttribute<ColumnAttribute>() ?? throw new Exception("Table: Invalid property")
			);

		var rows = new List<T>();

		for (var i = 0U; i < Header.Rows; i++)
		{
			rows.Add(ReadRow(properties, strings, out var rowLength));

			// TODO Not empty on TradeskillTier
			Stream.ReadBytes(Header.RowLength - rowLength);
		}

		Stream.Position = (long)idMapPosition;

		for (var i = 0U; i < Header.AutoIncrement; i++)
		{
			var id = Stream.ReadUInt32();

			Rows.Add(i, id == uint.MaxValue ? default : rows[(int)id]);
		}
	}

	private T ReadRow(Dictionary<PropertyInfo, ColumnAttribute> properties, Dictionary<ulong, string> strings, out ulong rowLength)
	{
		var row = Activator.CreateInstance<T>();
		rowLength = 0;

		foreach (var column in Columns)
		{
			var property = properties.FirstOrDefault(entry => entry.Value.Name == column.Name).Key ?? throw new Exception("Table: Invalid column");

			object value;

			switch (column.Type)
			{
				case TableColumnType.Uint:
					value = Stream.ReadUInt32();
					rowLength += 4;

					break;

				case TableColumnType.Float:
					value = Stream.ReadSingle();
					rowLength += 4;

					break;

				case TableColumnType.Bool:
					value = Stream.ReadUInt32() != 0;
					rowLength += 4;

					break;

				case TableColumnType.Ulong:
					value = Stream.ReadUInt64();
					rowLength += 8;

					break;

				case TableColumnType.String:
				{
					var offsetOrZero = Stream.ReadUInt32();
					var textOffset = offsetOrZero != 0 ? offsetOrZero : Stream.ReadUInt32();
					var unk1 = Stream.ReadUInt32();

					value = strings[textOffset];

					if (unk1 != 0)
						throw new Exception("Table: Invalid unk1");

					rowLength += (ulong)(offsetOrZero != 0 ? 8 : 12);

					break;
				}

				default:
					throw new ArgumentOutOfRangeException(Enum.GetName(column.Type));
			}

			property.SetValue(row, value);
		}

		return row;
	}
}
