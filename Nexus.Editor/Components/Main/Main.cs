using Godot;
using Nexus.Editor.Executables;
using System.Diagnostics;

namespace Nexus.Editor.Components.Main;

public partial class Main : Control
{
	[Export]
	public required PopupMenu FileMenu { get; set; }

	[Export]
	public required PopupMenu ToolsMenu { get; set; }

	[Export]
	public required PopupMenu HelpMenu { get; set; }

	[Export]
	public required Button PlayButton { get; set; }

	[Export]
	public required Button StopButton { get; set; }

	private Process? _process;

	public override void _Ready()
	{
		Owner = null;

		AddButton(FileMenu, "Test");
		AddSeparator(FileMenu, "Test");
		AddButton(FileMenu, "Exit", Exit);

		AddButton(ToolsMenu, "Map Editor");

		AddButton(HelpMenu, "About");

		PlayButton.Pressed += Play;
		StopButton.Pressed += Stop;
	}

	private void Play()
	{
		var clientExecutable = new ClientExecutable("../Assets/Client64/WildStar64.exe");
		clientExecutable.EnableBypassLauncher();

		_process = ExecutableRunner.Run(
			clientExecutable.Bytes,
			"../Assets/Client64/WildStar64.exe",
			"/auth localhost /authNc localhost /lang de /patcher localhost /SettingsKey WildStar /RealmDataCenterId 9"
		);

		PlayButton.Hide();
		StopButton.Show();
	}

	private void Stop()
	{
		_process?.Kill();
	}

	public override void _Process(double delta)
	{
		if (_process is not { HasExited: true })
			return;

		_process.Dispose();
		_process = null;

		PlayButton.Show();
		StopButton.Hide();
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

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);

		_process?.Dispose();
	}
}
