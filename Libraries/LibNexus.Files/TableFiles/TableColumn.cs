using LibNexus.Core.Extensions;

namespace LibNexus.Files.TableFiles;

public class TableColumn
{
	public const ulong Stride = 24;

	public string Name { get; }
	public TableColumnType Type { get; }
	public TableColumnFlags Flags { get; set; }

	public TableColumn(Stream stream, IReadOnlyDictionary<ulong, string> names)
	{
		var nameLength = stream.ReadUInt64();
		var nameOffset = stream.ReadUInt64();
		var type = stream.ReadUInt32();
		var flags = stream.ReadUInt32();

		if (!names.TryGetValue(nameOffset, out var name))
			throw new Exception("TableColumn: Invalid name offset");

		if ((ulong)name.Length != nameLength - 1)
			throw new Exception("TableColumn: Invalid name length");

		Name = name;
		Type = Enum.IsDefined(typeof(TableColumnType), type) ? (TableColumnType)type : throw new Exception("TableColumn: Invalid type");
		Flags = (TableColumnFlags)flags;
	}
}
