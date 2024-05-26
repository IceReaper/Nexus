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

	public ProgressTask? ProgressTask { get; set; }

	public event Action? OnComplete;

	public override void _Process(double delta)
	{
		Title.Text = ProgressTask?.Title;
		ProgressBar.Value = ProgressTask?.Progress ?? 0;
		Progress.Text = ProgressTask?.Status;

		if (ProgressTask is { Complete: false })
			return;

		Free();
		OnComplete?.Invoke();
	}
}
