namespace Nexus.Editor.Controls.MainMenuControl;

public partial class ToolsMenu : Menu
{
	public override void _Ready()
	{
		base._Ready();

		AddButton("Map Editor", OpenMapEditor);
	}

	private static void OpenMapEditor()
	{
		// TODO implement
	}
}
