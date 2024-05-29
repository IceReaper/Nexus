using LibNexus.Core.Extensions;

namespace LibNexus.Files.TableFiles;

public class TableHeader
{
	public ulong NameLength { get; }
	public ulong NameOffset { get; }
	public ulong RowLength { get; }
	public ulong Columns { get; }
	public ulong ColumnsOffset { get; }
	public ulong Rows { get; set; }
	public ulong RowsLength { get; set; }
	public ulong RowsOffset { get; }
	public ulong AutoIncrement { get; set; }
	public ulong IdMapOffset { get; set; }

	public TableHeader(Stream stream)
	{
		NameLength = stream.ReadUInt64();
		NameOffset = stream.ReadUInt64();
		RowLength = stream.ReadUInt64();
		Columns = stream.ReadUInt64();
		ColumnsOffset = stream.ReadUInt64();
		Rows = stream.ReadUInt64();
		RowsLength = stream.ReadUInt64();
		RowsOffset = stream.ReadUInt64();
		AutoIncrement = stream.ReadUInt64();
		IdMapOffset = stream.ReadUInt64();
	}
}
