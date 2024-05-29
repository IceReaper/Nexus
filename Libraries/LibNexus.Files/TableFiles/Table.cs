using LibNexus.Core.Extensions;
using System.Collections.ObjectModel;
using System.Reflection;

namespace LibNexus.Files.TableFiles;

public class Table<T> : TableBase
{
	public Collection<T> Rows { get; } = [];
	public Dictionary<uint, T?> IdMap { get; } = [];

	public Table(Stream stream)
		: base(stream)
	{
		if (Header.RowsOffset == 0)
			return;

		ReadRows();
		ReadIdMap();
	}

	private void ReadRows()
	{
		var rowsPosition = (ulong)Stream.Position;
		var stringsPosition = rowsPosition + Header.Rows * Header.RowLength;
		var idMapPosition = ContentStart + Header.IdMapOffset;

		Stream.Position = (long)stringsPosition;
		var strings = new Dictionary<ulong, string>();

		while ((ulong)Stream.Position < rowsPosition + Header.RowsLength)
			strings.Add((ulong)Stream.Position - rowsPosition, Stream.ReadWideString());

		SkipPadding();

		if ((ulong)Stream.Position != idMapPosition)
			throw new Exception("Table: Invalid id map offset");

		Stream.Position = (long)rowsPosition;

		var properties = typeof(T).GetProperties()
			.ToDictionary(
				static property => property,
				static property => property.GetCustomAttribute<ColumnAttribute>() ?? throw new Exception("Table: Invalid property")
			);

		for (var i = 0U; i < Header.Rows; i++)
		{
			var position = (ulong)Stream.Position;

			Rows.Add(ReadRow(properties, strings));

			// TODO Not empty on TradeskillTier
			Stream.ReadBytes(position + Header.RowLength - (ulong)Stream.Position);
		}

		if ((ulong)Stream.Position != stringsPosition)
			throw new Exception("Table: Invalid row length");

		Stream.Position = (long)idMapPosition;
	}

	private T ReadRow(Dictionary<PropertyInfo, ColumnAttribute> properties, Dictionary<ulong, string> strings)
	{
		var row = Activator.CreateInstance<T>();

		foreach (var column in Columns)
		{
			var property = properties.FirstOrDefault(entry => entry.Value.Name == column.Name).Key ?? throw new Exception("Table: Invalid column");

			object value;

			switch (column.Type)
			{
				case TableColumnType.Uint:
					value = Stream.ReadUInt32();

					break;

				case TableColumnType.Float:
					value = Stream.ReadSingle();

					break;

				case TableColumnType.Bool:
					value = Stream.ReadUInt32() != 0;

					break;

				case TableColumnType.Ulong:
					value = Stream.ReadUInt64();

					break;

				case TableColumnType.String:
				{
					var offsetOrZero = Stream.ReadUInt32();
					var textOffset = offsetOrZero != 0 ? offsetOrZero : Stream.ReadUInt32();
					var unk1 = Stream.ReadUInt32();

					value = strings[textOffset];

					if (unk1 != 0)
						throw new Exception("Table: Invalid unk1");

					break;
				}

				default:
					throw new ArgumentOutOfRangeException(Enum.GetName(column.Type));
			}

			property.SetValue(row, value);
		}

		return row;
	}

	private void ReadIdMap()
	{
		for (var i = 0U; i < Header.AutoIncrement; i++)
		{
			var id = Stream.ReadUInt32();

			if (id != uint.MaxValue)
				IdMap.Add(i, Rows[(int)id]);
		}
	}
}
