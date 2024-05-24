using Godot;
using LibNexus.Core;
using LibNexus.Editor;
using Nexus.Editor.Controls.ProgressDialogControl;

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
			Unresizable = true
		};

		dialog.DirSelected += path =>
		{
			dialog.Free();
			TryOpen(Project.Create(path));
		};

		dialog.Canceled += () => dialog.Free();

		MainMenu.Main.AddChild(dialog);

		dialog.Show();
		dialog.MoveToCenter();
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
			Unresizable = true
		};

		dialog.FileSelected += path =>
		{
			dialog.Free();
			TryOpen(new Project(path));
		};

		dialog.Canceled += () => dialog.Free();

		MainMenu.Main.AddChild(dialog);

		dialog.Show();
		dialog.MoveToCenter();
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

	private void TryOpen(Project project)
	{
		if (Project.ValidateInstallation(Path.Combine(project.RootPath, Project.DistDirectory)))
			MainMenu.Main.Project = project;
		else
			ShowClientInvalidMessage(project);
	}

	private void ShowClientInvalidMessage(Project project)
	{
		var dialog = new ConfirmationDialog { Title = "Client not found", DialogText = "No valid client found, please locate WildStar client." };

		dialog.Confirmed += () => LocateClient(project);
		dialog.Canceled += () => dialog.Free();

		MainMenu.Main.AddChild(dialog);

		dialog.Show();
		dialog.MoveToCenter();
	}

	private void LocateClient(Project project)
	{
		var dialog = new FileDialog
		{
			Access = FileDialog.AccessEnum.Filesystem,
			FileMode = FileDialog.FileModeEnum.OpenFile,
			Filters = ["WildStar launcher", "WildStar.exe"],
			Title = "Locate WildStar launcher",
			Size = new Vector2I(640, 360),
			Unresizable = true
		};

		dialog.FileSelected += path =>
		{
			dialog.Free();

			var directory = Path.GetDirectoryName(path) ?? string.Empty;

			if (Project.ValidateInstallation(directory))
				CopyClient(directory, project);
			else
				ShowClientInvalidMessage(project);
		};

		dialog.Canceled += () => dialog.Free();

		MainMenu.Main.AddChild(dialog);

		dialog.Show();
		dialog.MoveToCenter();
	}

	private void CopyClient(string sourceDirectory, Project project)
	{
		var copier = new DirectoryCopier();
		copier.Add(sourceDirectory, Path.Combine(project.RootPath, Project.DistDirectory));

		var dialog = (ProgressDialog)GD.Load<PackedScene>("res://Controls/ProgressDialogControl/ProgressDialog.tscn").Instantiate();

		dialog.Window.Title = "Copying client";

		dialog.ProgressFunction = () => copier.CopiedBytes / (float)copier.TotalBytes;

		dialog.ProgressText = () => string.Join(
			" / ",
			[
				$"{Math.Ceiling(copier.CopiedBytes / (double)DirectoryCopier.MegaByte)} MB",
				$"{Math.Ceiling(copier.TotalBytes / (double)DirectoryCopier.MegaByte)} MB"
			]
		);

		dialog.Complete = () => copier.Complete;

		dialog.OnComplete += () =>
		{
			dialog.Free();
			MainMenu.Main.Project = project;
		};

		MainMenu.Main.AddChild(dialog);

		dialog.ShowAndMoveToCenter();

		copier.Run();
	}
}
