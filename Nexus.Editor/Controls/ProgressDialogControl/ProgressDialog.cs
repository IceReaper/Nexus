using Godot;
using LibNexus.Core;

namespace Nexus.Editor.Controls.ProgressDialogControl;

public partial class ProgressDialog : Control
{
	[Export]
	public required Window Window { get; set; }

	[Export]
	public required Label Title { get; set; }

	[Export]
	public required ProgressBar ProgressBar { get; set; }

	[Export]
	public required Label Progress { get; set; }

	public required ProgressTask ProgressTask { get; set; }

	public event Action? OnComplete;

	public override void _Process(double delta)
	{
		Title.Text = ProgressTask.Title;
		ProgressBar.Value = ProgressTask.Progress;
		Progress.Text = ProgressTask.Status;

		if (!ProgressTask.Complete)
			return;

		Free();
		OnComplete?.Invoke();
	}
}
