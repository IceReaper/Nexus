using LibNexus.Core.Extensions;
using System.Collections.ObjectModel;

namespace LibNexus.Files.TableFiles;

public class TableBase
{
	private const string Magic = "DTBL";
	private const uint Version = 0;

	protected Stream Stream { get; }

	protected TableHeader Header { get; }
	protected ulong ContentStart { get; }

	public string Name { get; }
	public Collection<TableColumn> Columns { get; } = [];

	public TableBase(Stream stream)
	{
		Stream = stream;

		var magic = Stream.ReadWord();
		var version = Stream.ReadUInt32();

		if (magic != Magic)
			throw new Exception("Table: Invalid magic");

		if (version != Version)
			throw new Exception("Table: Invalid version");

		Header = new TableHeader(Stream);
		SkipPadding();

		ContentStart = (ulong)Stream.Position;

		if ((ulong)Stream.Position != ContentStart + Header.NameOffset)
			throw new Exception("Table: Invalid name offset");

		Name = Stream.ReadWideString();
		SkipPadding();

		if ((ulong)Name.Length != Header.NameLength - 1)
			throw new Exception("Table: Invalid name length");

		ReadColumns();
	}

	private void ReadColumns()
	{
		var rowsPosition = Header.RowsOffset == 0 ? (ulong)Stream.Length : ContentStart + Header.RowsOffset;
		var columnsPosition = (ulong)Stream.Position;

		if (columnsPosition != ContentStart + Header.ColumnsOffset)
			throw new Exception("Table: Invalid columns offset");

		Stream.Position = (long)(columnsPosition + Header.Columns * TableColumn.Stride);
		SkipPadding();

		var columnNamesPosition = (ulong)Stream.Position;
		var strings = new Dictionary<ulong, string>();

		for (var i = 0UL; i < Header.Columns; i++)
		{
			strings.Add((ulong)Stream.Position - columnNamesPosition, Stream.ReadWideString());
			SkipPadding();
		}

		if ((ulong)Stream.Position != rowsPosition)
			throw new Exception("Table: Invalid rows offset");

		Stream.Position = (long)columnsPosition;

		for (var i = 0UL; i < Header.Columns; i++)
			Columns.Add(new TableColumn(Stream, strings));

		Stream.Position = (long)rowsPosition;
	}

	protected void SkipPadding()
	{
		if (Stream.Position % 16 != 0)
			Stream.Position += 16 - Stream.Position % 16;
	}
}
