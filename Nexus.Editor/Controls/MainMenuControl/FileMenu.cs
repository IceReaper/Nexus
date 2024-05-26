using Godot;
using LibNexus.Editor;

namespace Nexus.Editor.Controls.MainMenuControl;

public partial class FileMenu : Menu
{
	public override void _Ready()
	{
		base._Ready();
		AddButton("New Project", NewProject, Key.N);
		AddButton("Open project", OpenProject, Key.O);
		AddButton("Close project", CloseProject, Key.C, true);
		AddSeparator();
		AddButton("Settings", OpenSettings, Key.S);
		AddSeparator();
		AddButton("Invalidate caches", InvalidateCaches, Key.I, true);
		AddButton("Exit", Exit, Key.E);
	}

	private void NewProject()
	{
		var dialog = new FileDialog
		{
			Access = FileDialog.AccessEnum.Filesystem,
			FileMode = FileDialog.FileModeEnum.OpenDir,
			Title = "New project",
			Size = new Vector2I(640, 360),
			Unresizable = true,
			Visible = true,
			InitialPosition = WindowInitialPosition.CenterMainWindowScreen
		};

		dialog.DirSelected += path =>
		{
			dialog.Free();

			var openProjectProcess = new OpenProjectProcess(MainMenu.Main, Project.Create(path));
			openProjectProcess.TryOpen();
		};

		dialog.Canceled += () => dialog.Free();

		MainMenu.Main.AddChild(dialog);
	}

	private void OpenProject()
	{
		var dialog = new FileDialog
		{
			Access = FileDialog.AccessEnum.Filesystem,
			FileMode = FileDialog.FileModeEnum.OpenFile,
			Filters = ["Nexus project files (*.nexus)", "*.nexus"],
			Title = "Open project",
			Size = new Vector2I(640, 360),
			Unresizable = true,
			Visible = true,
			InitialPosition = WindowInitialPosition.CenterMainWindowScreen
		};

		dialog.FileSelected += path =>
		{
			dialog.Free();

			var openProjectProcess = new OpenProjectProcess(MainMenu.Main, path);
			openProjectProcess.TryOpen();
		};

		dialog.Canceled += () => dialog.Free();

		MainMenu.Main.AddChild(dialog);
	}

	private void CloseProject()
	{
		MainMenu.Main.Project = null;
	}

	private static void OpenSettings()
	{
		// TODO implement
	}

	private static void InvalidateCaches()
	{
		// TODO implement
	}

	private void Exit()
	{
		MainMenu.Main.GetTree().Quit();
	}
}
