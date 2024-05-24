namespace Nexus.Editor.Controls.ThemeBaseControl;

public readonly struct Sides : IEquatable<Sides>
{
	public int Top { get; }
	public int Right { get; }
	public int Bottom { get; }
	public int Left { get; }

	public Sides(int all)
	{
		Top = Right = Bottom = Left = all;
	}

	public Sides(int vertical, int horizontal)
	{
		Top = Bottom = vertical;
		Right = Left = horizontal;
	}

	public Sides(int top, int right, int bottom, int left)
	{
		Top = top;
		Right = right;
		Bottom = bottom;
		Left = left;
	}

	public override string ToString()
	{
		return string.Join(",", new[] { Top, Right, Bottom, Left });
	}

	public override bool Equals(object? obj)
	{
		return obj is Sides sides && Equals(sides);
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(Top, Right, Bottom, Left);
	}

	public bool Equals(Sides other)
	{
		return Top == other.Top && Right == other.Right && Bottom == other.Bottom && Left == other.Left;
	}

	public static bool operator ==(Sides left, Sides right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(Sides left, Sides right)
	{
		return !(left == right);
	}
}
