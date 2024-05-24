using LibNexus.Core.Extensions;
using System.Collections.ObjectModel;

namespace LibNexus.Files.PackFiles;

public class PackPhysicalPage
{
	public const uint Stride = 16;

	private readonly Stream _stream;

	private ulong _length;
	private ulong _offset;

	public ulong Length
	{
		get => _length;

		set
		{
			if (_length == value)
				return;

			if (_length > value)
			{
				_stream.Position = (long)(_offset + value);
				_stream.WriteBytes(new byte[_length - value]);
			}

			_stream.Position = (long)(_offset - Stride / 2);
			_stream.WriteUInt64(value);

			_stream.Position = (long)(_offset + _length);
			_stream.WriteUInt64(0);

			_stream.Position = (long)(_offset + value);
			_stream.WriteUInt64(value);

			_length = value;
		}
	}

	public ulong Offset
	{
		get => _offset;

		set
		{
			if (_offset == value)
				return;

			_stream.Position = (long)(_offset - Stride / 2);
			_stream.WriteUInt64(0);
			var data = _stream.ReadBytes(_length);
			_stream.WriteUInt64(0);

			_stream.Position = (long)(value - Stride / 2);
			_stream.WriteUInt64(_length);
			_stream.WriteBytes(data);
			_stream.WriteUInt64(_length);

			foreach (var virtualPage in VirtualPages)
				virtualPage.Offset = value;

			_offset = value;
		}
	}

	public PackPhysicalPage? Last { get; set; }
	public PackPhysicalPage? Next { get; set; }
	public Collection<PackVirtualPage> VirtualPages { get; } = [];

	public PackPhysicalPage(Stream stream)
	{
		_stream = stream;

		// TODO length can be negative... If, what does it mean? Deleted ones?
		_length = _stream.ReadUInt64();

		if ((long)_length < 0)
			_length = (ulong)((long)_length * -1);

		_offset = (ulong)_stream.Position;
		_stream.Position += (long)_length;
		var length2 = _stream.ReadUInt64();

		if ((long)length2 < 0)
			length2 = (ulong)((long)length2 * -1);

		if (_length != length2)
			throw new Exception("PackPhysicalPage: Invalid length");
	}

	public static PackPhysicalPage Create(Stream stream, ulong length)
	{
		stream.WriteUInt64(length);
		stream.WriteBytes(new byte[length]);
		stream.WriteUInt64(length);

		stream.Position -= (long)(length + Stride);

		return new PackPhysicalPage(stream);
	}
}
