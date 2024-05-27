using Godot;

namespace Nexus.Editor.Controls.MainMenuControl;

public partial class HelpMenu : Menu
{
	[Export]
	public required PackedScene About { get; set; }

	public override void _Ready()
	{
		base._Ready();

		AddButton("About", OpenAbout);
	}

	private void OpenAbout()
	{
		MainMenu.Main.AddChild(About.Instantiate());
	}
}
