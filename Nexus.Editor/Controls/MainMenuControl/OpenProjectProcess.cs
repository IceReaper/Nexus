using Godot;
using LibNexus.Core;
using LibNexus.Editor;
using Nexus.Editor.Controls.MainControl;
using Nexus.Editor.Controls.ProgressDialogControl;

namespace Nexus.Editor.Controls.MainMenuControl;

public class OpenProjectProcess
{
	private readonly Main _main;
	private readonly string _projectFilePath;

	private readonly string _targetLocation;

	public OpenProjectProcess(Main main, string projectFilePath)
	{
		_main = main;
		_projectFilePath = projectFilePath;

		_targetLocation = Path.Combine(Path.GetDirectoryName(projectFilePath) ?? string.Empty, Project.DistDirectory);
	}

	public void TryOpen()
	{
		if (!Project.ValidateInstallation(_targetLocation))
		{
			ShowClientInvalidMessage();

			return;
		}

		var project = new Project(_projectFilePath);

		var dialog = (ProgressDialog)GD.Load<PackedScene>("res://Controls/ProgressDialogControl/ProgressDialog.tscn").Instantiate();
		dialog.Window.Title = "Opening project";
		dialog.ProgressTask = project.Load();
		dialog.OnComplete += () => _main.Project = project;

		_main.AddChild(dialog);
	}

	private void ShowClientInvalidMessage()
	{
		var dialog = new ConfirmationDialog { Title = "Client not found", DialogText = "No valid client found, please locate WildStar client." };

		dialog.Confirmed += () =>
		{
			dialog.Free();

			LocateClient();
		};

		dialog.Canceled += () => dialog.Free();

		_main.AddChild(dialog);
	}

	private void LocateClient()
	{
		var dialog = new FileDialog
		{
			Access = FileDialog.AccessEnum.Filesystem,
			FileMode = FileDialog.FileModeEnum.OpenFile,
			Filters = ["WildStar launcher", "WildStar.exe"],
			Title = "Locate WildStar launcher",
			Size = new Vector2I(640, 360),
			Unresizable = true,
			Visible = true,
			InitialPosition = Window.WindowInitialPosition.CenterMainWindowScreen
		};

		dialog.FileSelected += path =>
		{
			dialog.Free();

			var directory = Path.GetDirectoryName(path) ?? string.Empty;

			if (Project.ValidateInstallation(directory))
				CopyClient(directory);
			else
				ShowClientInvalidMessage();
		};

		dialog.Canceled += () => dialog.Free();

		_main.AddChild(dialog);
	}

	private void CopyClient(string sourceDirectory)
	{
		var directoryCopier = new DirectoryCopier();
		directoryCopier.Add(sourceDirectory, _targetLocation);

		var dialog = (ProgressDialog)GD.Load<PackedScene>("res://Controls/ProgressDialogControl/ProgressDialog.tscn").Instantiate();
		dialog.Window.Title = "Copying client";
		dialog.ProgressTask = directoryCopier.Run();
		dialog.OnComplete += TryOpen;

		_main.AddChild(dialog);
	}
}
