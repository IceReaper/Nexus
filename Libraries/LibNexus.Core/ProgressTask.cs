namespace LibNexus.Core;

public class ProgressTask
{
	public string Title { get; set; } = string.Empty;
	public ulong Total { get; set; }
	public ulong Completed { get; set; }
	public string Status { get; set; } = string.Empty;
	public bool Complete { get; private set; }

	public float Progress => Completed / (float)Total;

	public void Run(Action<ProgressTask> task)
	{
		if (Complete)
			return;

		Task.Run(
			() =>
			{
				task(this);
				Complete = true;
			}
		);
	}

	public void UpdateDefault()
	{
		Status = $"{Completed} / {Total}";
	}
}
