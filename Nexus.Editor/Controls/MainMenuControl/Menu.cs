using Godot;

namespace Nexus.Editor.Controls.MainMenuControl;

public partial class Menu : PopupMenu
{
	[Export]
	public required MainMenu MainMenu { get; set; }

	private readonly Dictionary<int, (Action Action, bool RequireProject)> _buttons = [];

	public override void _Ready()
	{
		IndexPressed += index => _buttons[(int)index].Action();

		MainMenu.Main.OnProjectChanged += ProjectChanged;
	}

	protected void AddButton(string label, Action action, Key shortcut = Key.None, bool requireProject = false)
	{
		var id = ItemCount;

		AddItem(label, id, shortcut);

		var index = GetItemIndex(id);

		SetItemDisabled(index, requireProject && MainMenu.Main.Project == null);
		_buttons.Add(index, (action, requireProject));
	}

	protected void AddSeparator(string? label = null)
	{
		AddSeparator(label, ItemCount);
	}

	private void ProjectChanged()
	{
		foreach (var (index, button) in _buttons)
		{
			if (button.RequireProject)
				SetItemDisabled(index, MainMenu.Main.Project == null);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);

		if (disposing)
			MainMenu.Main.OnProjectChanged -= ProjectChanged;
	}
}
