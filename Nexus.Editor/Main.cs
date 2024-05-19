using Godot;

namespace Nexus.Editor;

public partial class Main : Node
{
	public Main()
	{
		Console.WriteLine("constructor");
	}

	public override void _Ready()
	{
		Console.WriteLine("ready");
	}

	public override void _Process(double delta)
	{
		Console.WriteLine("process");
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);

		Console.WriteLine("dispose");
	}
}
