namespace Nexus.Editor.Caching;

public readonly struct Subscriber : IEquatable<Subscriber>
{
	private readonly int _hashCode;

	public Subscriber(object thing)
	{
		_hashCode = thing.GetHashCode();
	}

	public override bool Equals(object? obj)
	{
		return obj is Subscriber fileId && Equals(fileId);
	}

	public bool Equals(Subscriber other)
	{
		return other._hashCode == _hashCode;
	}

	public override int GetHashCode()
	{
		return _hashCode;
	}

	public static bool operator ==(Subscriber left, Subscriber right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(Subscriber left, Subscriber right)
	{
		return !(left == right);
	}
}
