using Godot;

namespace Nexus.Editor.Controls.ProgressDialogControl;

public partial class ProgressDialog : Control
{
	[Export]
	public required Window Window { get; set; }

	[Export]
	public required ProgressBar ProgressBar { get; set; }

	[Export]
	public required Label Progress { get; set; }

	public required Func<float> ProgressFunction { get; set; }
	public required Func<string> ProgressText { get; set; }
	public required Func<bool> Complete { get; set; }

	public event Action? OnComplete;

	public override void _Process(double delta)
	{
		ProgressBar.Value = ProgressFunction();
		Progress.Text = ProgressText();

		if (Complete())
			OnComplete?.Invoke();
	}

	public void ShowAndMoveToCenter()
	{
		Window.Show();
		Window.MoveToCenter();
	}
}
