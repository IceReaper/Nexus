namespace LibNexus.Core.Streams;

public class SegmentStream : Stream
{
	public override bool CanRead => _stream.CanRead;
	public override bool CanSeek => _stream.CanSeek;
	public override bool CanWrite => _stream.CanWrite;
	public override long Length => _length;

	public override long Position
	{
		get => _stream.Position - _position;
		set => Seek(value, SeekOrigin.Begin);
	}

	private readonly Stream _stream;
	private readonly long _position;
	private readonly bool _leaveOpen;

	private long _length;

	public SegmentStream(Stream stream, long position, long length, bool leaveOpen)
	{
		_stream = stream;
		_position = position;
		_length = length;
		_leaveOpen = leaveOpen;
	}

	public override void Flush()
	{
		_stream.Flush();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (count > Length - Position)
			throw new ArgumentException("Cannot read past the end of the stream.");

		return _stream.Read(buffer, offset, count);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		var newOffset = origin switch
		{
			SeekOrigin.Begin => offset,
			SeekOrigin.Current => Position + offset,
			SeekOrigin.End => Position + Length + offset,
			_ => throw new ArgumentOutOfRangeException(nameof(origin))
		};

		if (newOffset > Length)
			throw new ArgumentException("Cannot seek past the end of the stream.");

		if (newOffset < 0)
			throw new ArgumentException("Cannot seek before the beginning of the stream.");

		return _stream.Seek(_position + newOffset, SeekOrigin.Begin);
	}

	public override void SetLength(long value)
	{
		_length = value;
		_stream.SetLength(_position + value);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (count > Length - Position)
			throw new ArgumentException("Cannot write past the end of the stream.");

		_stream.Write(buffer, offset, count);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);

		if (disposing && !_leaveOpen)
			_stream.Dispose();
	}
}
