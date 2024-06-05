using LibNexus.Core.Extensions;

namespace LibNexus.Files.TableFiles;

public class TableColumn
{
	public const ulong Stride = 24;

	public string Name { get; }
	public TableColumnType Type { get; }
	public TableColumnFlags Flags { get; }

	public TableColumn(Stream stream, IReadOnlyDictionary<ulong, string> names)
	{
		var nameLength = stream.ReadUInt64();
		var nameOffset = stream.ReadUInt64();
		var type = stream.ReadUInt32();
		var flags = stream.ReadUInt32();

		Name = names[nameOffset];
		Type = Enum.IsDefined(typeof(TableColumnType), type) ? (TableColumnType)type : throw new FileFormatException(typeof(Table), nameof(Type));
		Flags = (TableColumnFlags)flags;

		if ((ulong)Name.Length != nameLength - 1)
			throw new FileFormatException(typeof(Table), nameof(nameLength));
	}
}
