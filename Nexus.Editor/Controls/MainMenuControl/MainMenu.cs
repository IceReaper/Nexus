using Godot;
using Nexus.Editor.Controls.MainControl;

namespace Nexus.Editor.Controls.MainMenuControl;

public partial class MainMenu : Control
{
	[Export]
	public required Main Main { get; set; }
}
