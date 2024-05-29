using Godot;
using LibNexus.Core;
using LibNexus.Editor;
using Nexus.Editor.Controls.MainControl;
using Nexus.Editor.Controls.ProgressDialogControl;

namespace Nexus.Editor.Controls.MainMenuControl;

public class OpenProjectProcess
{
	private const string DefaultPath = @"C:\Program Files (x86)\NCSOFT\WildStar";

	private readonly Main _main;
	private readonly string _projectFilePath;
	private readonly PackedScene _progressDialogScene;

	private readonly string _targetLocation;

	public OpenProjectProcess(Main main, string projectFilePath, PackedScene progressDialogScene)
	{
		_main = main;
		_projectFilePath = projectFilePath;
		_progressDialogScene = progressDialogScene;

		_targetLocation = Path.Combine(Path.GetDirectoryName(projectFilePath) ?? string.Empty, Project.DistDirectory);
	}

	public void TryOpen()
	{
		if (!Project.ValidateInstallation(_targetLocation))
		{
			ShowClientInvalidMessage();

			return;
		}

		var dialog = (ProgressDialog)_progressDialogScene.Instantiate();
		dialog.Window.Title = "Opening project";

		dialog.Run((progress, cancellationToken) => Project.Load(_projectFilePath, progress, cancellationToken), result => _main.Project = result);

		_main.AddChild(dialog);
	}

	private void ShowClientInvalidMessage()
	{
		var dialog = new ConfirmationDialog
		{
			Title = "Client not found",
			DialogText = "No valid client found, please locate WildStar client.",
			Visible = true,
			InitialPosition = Window.WindowInitialPosition.CenterMainWindowScreen
		};

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
			CurrentDir = DefaultPath,
			Size = new Vector2I(640, 360),
			Unresizable = true,
			Visible = true,
			InitialPosition = Window.WindowInitialPosition.CenterMainWindowScreen
		};

		dialog.FileSelected += path =>
		{
			var directory = Path.GetDirectoryName(path) ?? string.Empty;

			if (Project.ValidateInstallation(directory))
				CopyClient(directory);
			else
				ShowClientInvalidMessage();
		};

		_main.AddChild(dialog);
	}

	private void CopyClient(string sourceDirectory)
	{
		var directoryCopier = new DirectoryCopier();
		directoryCopier.Add(sourceDirectory, _targetLocation);

		var dialog = (ProgressDialog)_progressDialogScene.Instantiate();
		dialog.Window.Title = "Copying client";
		dialog.Run((progress, cancellationToken) => directoryCopier.Run(progress, cancellationToken), TryOpen);
		_main.AddChild(dialog);
	}
}
