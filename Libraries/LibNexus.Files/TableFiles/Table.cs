using LibNexus.Core.Extensions;
using LibNexus.Core.Streams;
using System.Collections.ObjectModel;

namespace LibNexus.Files.TableFiles;

public class Table
{
	private static readonly Identifier Identifier = new("DTBL", 0);

	protected Stream Data { get; }

	protected TableHeader Header { get; }

	public string Name { get; }
	public Collection<TableColumn> Columns { get; } = [];

	public Table(Stream stream)
	{
		FileFormatException.ThrowIf<Table>(nameof(Identifier), new Identifier(stream) != Identifier);
		Header = new TableHeader(stream);
		Data = new SegmentStream(stream, Identifier.Size + TableHeader.Size, stream.Length - Identifier.Size - TableHeader.Size, true);

		FileFormatException.ThrowIf<Table>(nameof(Header.NameOffset), (ulong)Data.Position != Header.NameOffset);
		Name = Data.ReadWideString(Header.NameLength);
		Data.SkipPadding(16);

		FileFormatException.ThrowIf<Table>(nameof(Header.ColumnsOffset), (ulong)Data.Position != Header.ColumnsOffset);
		Data.Position += (long)(Header.Columns * TableColumn.Stride);
		Data.SkipPadding(16);

		var columnNamesPosition = (ulong)Data.Position;
		var strings = new Dictionary<ulong, string>();

		for (var i = 0UL; i < Header.Columns; i++)
		{
			strings.Add((ulong)Data.Position - columnNamesPosition, Data.ReadWideString());
			Data.SkipPadding(16);
		}

		FileFormatException.ThrowIf<Table>(nameof(Header.RowsOffset), Header.RowsOffset != 0 && (ulong)Data.Position != Header.RowsOffset);
		Data.Position = (long)Header.ColumnsOffset;

		for (var i = 0UL; i < Header.Columns; i++)
			Columns.Add(new TableColumn(Data, strings));
	}
}
