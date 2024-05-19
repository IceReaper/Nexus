using System.Text;

namespace LibNexus.Files.Extensions;

public static class StreamExtensions
{
	public static uint ReadUInt32(this Stream stream)
	{
		return BitConverter.ToUInt32(stream.ReadBytes(sizeof(uint)));
	}

	public static ulong ReadUInt64(this Stream stream)
	{
		return BitConverter.ToUInt64(stream.ReadBytes(sizeof(ulong)));
	}

	public static string ReadWord(this Stream stream)
	{
		return Encoding.ASCII.GetString(ReadBytes(stream, sizeof(uint)).Reverse().ToArray());
	}

	public static string ReadString(this Stream stream)
	{
		var value = string.Empty;

		while (true)
		{
			var character = stream.ReadBytes(sizeof(byte))[0];

			if (character == 0x00)
				break;

			value += (char)character;
		}

		return value;
	}

	public static byte[] ReadBytes(this Stream stream, ulong length)
	{
		var result = new byte[length];
		var read = 0UL;

		while (read < length)
			read += (ulong)stream.Read(result, (int)read, (int)(length - read));

		return result;
	}

	public static void WriteUInt32(this Stream stream, uint value)
	{
		stream.WriteBytes(BitConverter.GetBytes(value));
	}

	public static void WriteUInt64(this Stream stream, ulong value)
	{
		stream.WriteBytes(BitConverter.GetBytes(value));
	}

	public static void WriteWord(this Stream stream, string value)
	{
		if (value.Length != sizeof(uint))
			throw new OverflowException("A word must be 4 characters long.");

		stream.WriteBytes(Encoding.ASCII.GetBytes(value).Reverse().ToArray());
	}

	public static void WriteString(this Stream stream, string value)
	{
		stream.WriteBytes(Encoding.ASCII.GetBytes(value));
		stream.WriteBytes(new byte[1]);
	}

	public static void WriteBytes(this Stream stream, byte[] value)
	{
		stream.Write(value);
	}
}
