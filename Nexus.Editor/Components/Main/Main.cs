using Godot;

namespace Nexus.Editor.Components.Main;

public partial class Main : Control
{
	[Export]
	public required PopupMenu FileMenu { get; set; }

	[Export]
	public required PopupMenu ToolsMenu { get; set; }

	[Export]
	public required PopupMenu HelpMenu { get; set; }

	public override void _Ready()
	{
		Owner = null;

		AddButton(FileMenu, "Test");
		AddSeparator(FileMenu, "Test");
		AddButton(FileMenu, "Exit", Exit);

		AddButton(ToolsMenu, "Map Editor");

		AddButton(HelpMenu, "About");
	}

	private void Exit()
	{
		GetTree().Quit();
	}

	private static void AddButton(PopupMenu popupMenu, string label, Action? action = null, Key shortcut = Key.None)
	{
		var id = popupMenu.ItemCount;

		popupMenu.AddItem(label, id, shortcut);

		if (action != null)
		{
			popupMenu.IndexPressed += index =>
			{
				var which = popupMenu.GetItemText((int)index);

				if (which == label)
					action();
			};
		}
		else
			popupMenu.SetItemDisabled(popupMenu.GetItemIndex(id), true);
	}

	private static void AddSeparator(PopupMenu popupMenu, string label)
	{
		popupMenu.AddSeparator(label, popupMenu.ItemCount);
	}
}
