using Godot;
using LibNexus.Core;
using Nexus.Editor.Extensions;

namespace Nexus.Editor.Controls.ProgressDialogControl;

public partial class ProgressDialog : Window
{
	[Export]
	public required Control Root { get; set; }

	[Export]
	public required PackedScene ProgressEntry { get; set; }

	private readonly Progress _progress = new();
	private readonly CancellationTokenSource _cancellationTokenSource = new();

	private Task? _task;
	private Action? _complete;

	public override void _Ready()
	{
		var progressEntry = (ProgressEntry)ProgressEntry.Instantiate();
		progressEntry.Progress = _progress;
		progressEntry.Template = ProgressEntry;
		Root.AddChild(progressEntry);

		CloseRequested += () =>
		{
			_cancellationTokenSource.Cancel();
			QueueFree();
		};
	}

	public override void _Process(double delta)
	{
		Size = Size with { Y = 0 };
		this.Jail();

		if (_task == null)
			return;

		if (!_task.IsCompleted)
			return;

		_complete?.Invoke();
		QueueFree();
	}

	public void Run(Func<Progress, CancellationToken, Task> createTask, Action result)
	{
		_task = Task.Run(async () => await createTask(_progress, _cancellationTokenSource.Token));
		_complete = result;
	}

	public void Run<T>(Func<Progress, CancellationToken, Task<T>> createTask, Action<T> result)
	{
		var task = Task.Run(async () => await createTask(_progress, _cancellationTokenSource.Token));

		_task = task;
		_complete = () => result(task.Result);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);

		if (disposing)
			_cancellationTokenSource.Dispose();
	}
}
