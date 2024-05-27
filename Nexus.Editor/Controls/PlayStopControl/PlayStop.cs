using Godot;
using Nexus.Editor.Controls.MainControl;
using System.Diagnostics;

namespace Nexus.Editor.Controls.PlayStopControl;

public partial class PlayStop : Control
{
	[Export]
	public required Main Main { get; set; }

	[Export]
	public required Button PlayButton { get; set; }

	[Export]
	public required Button StopButton { get; set; }

	private Process? _process;

	public override void _Ready()
	{
		StopButton.Hide();

		PlayButton.Pressed += Play;
		StopButton.Pressed += Stop;

		PlayButton.Disabled = Main.Project == null;

		Main.OnProjectChanged += ProjectChanged;
	}

	public override void _Process(double delta)
	{
		if (_process is not { HasExited: true })
			return;

		_process.Dispose();
		_process = null;

		if (Main.Project != null)
		{
			foreach (var fileSystem in Main.Project.FileSystems.Values)
				fileSystem.Open();
		}

		PlayButton.Show();
		StopButton.Hide();
	}

	private void ProjectChanged()
	{
		Stop();

		PlayButton.Disabled = Main.Project == null;
	}

	private void Play()
	{
		if (Main.Project == null)
			return;

		foreach (var fileSystem in Main.Project.FileSystems.Values)
			fileSystem.Close();

		_process = Main.Project.Run();

		PlayButton.Hide();
		StopButton.Show();
	}

	private void Stop()
	{
		_process?.Kill();
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);

		if (disposing)
			_process?.Dispose();
	}
}
