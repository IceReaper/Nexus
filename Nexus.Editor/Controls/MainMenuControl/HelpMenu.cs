using Godot;
using Nexus.Editor.Controls.AboutControl;

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
		var dialog = (About)About.Instantiate();
		MainMenu.Main.AddChild(dialog);
	}
}
