using System.Security.Cryptography;

namespace LibNexus.Files;

public readonly struct Hash : IEquatable<Hash>
{
	public const uint Length = 20;

	public byte[] Bytes { get; } = new byte[Length];

	public Hash(byte[] bytes)
	{
		Array.Copy(bytes, Bytes, Length);
	}

	public static Hash Create(byte[] data)
	{
		return new Hash(SHA1.HashData(data));
	}

	public bool Validate(byte[] data)
	{
		return Bytes.SequenceEqual(SHA1.HashData(data));
	}

	public override bool Equals(object? obj)
	{
		return obj is Hash fileId && Equals(fileId);
	}

	public bool Equals(Hash other)
	{
		return other.Bytes.SequenceEqual(Bytes);
	}

	public override int GetHashCode()
	{
		return Bytes.GetHashCode();
	}

	public static bool operator ==(Hash left, Hash right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(Hash left, Hash right)
	{
		return !(left == right);
	}
}
