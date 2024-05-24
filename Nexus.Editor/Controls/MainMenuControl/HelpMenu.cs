using Godot;

namespace Nexus.Editor.Controls.MainMenuControl;

public partial class HelpMenu : Menu
{
	public override void _Ready()
	{
		base._Ready();

		AddButton("About", OpenAbout);
	}

	private void OpenAbout()
	{
		MainMenu.Main.AddChild(GD.Load<PackedScene>("res://Controls/AboutControl/About.tscn").Instantiate());
	}
}
