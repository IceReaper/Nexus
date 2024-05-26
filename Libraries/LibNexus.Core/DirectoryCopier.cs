using LibNexus.Core.Extensions;

namespace LibNexus.Core;

public class DirectoryCopier
{
	private const int MegaByte = 1024 * 1024;

	private readonly ProgressTask _progressTask = new() { Title = "Copying files" };
	private readonly Dictionary<string, string> _tasks = [];

	public void Add(string source, string target)
	{
		Measure(source);

		_tasks.Add(source, target);

		UpdateStatus();
	}

	private void Measure(string path)
	{
		foreach (var directory in Directory.GetDirectories(path))
			Measure(directory);

		foreach (var file in Directory.GetFiles(path))
			_progressTask.Total += (ulong)new FileInfo(file).Length;
	}

	public ProgressTask Run()
	{
		if (!_progressTask.Complete)
			_progressTask.Run(RunInternal);

		return _progressTask;
	}

	private void RunInternal(ProgressTask progressTask)
	{
		foreach (var (source, target) in _tasks)
			Copy(source, target);
	}

	private void Copy(string source, string target)
	{
		foreach (var sourceDirectory in Directory.GetDirectories(source))
		{
			var targetDirectory = Path.Combine(target, Path.GetFileName(sourceDirectory));

			Directory.CreateDirectory(targetDirectory);
			Copy(sourceDirectory, targetDirectory);
		}

		foreach (var sourceFile in Directory.GetFiles(source))
		{
			var targetFile = Path.Combine(target, Path.GetFileName(sourceFile));

			using var input = File.Open(sourceFile, FileMode.Open, FileAccess.Read);
			using var output = File.Open(targetFile, FileMode.Create, FileAccess.Write);

			while (input.Position < input.Length)
			{
				var amount = (ulong)Math.Min(MegaByte, input.Length - input.Position);

				output.WriteBytes(input.ReadBytes(amount));

				_progressTask.Completed += amount;
				UpdateStatus();
			}

			File.SetCreationTimeUtc(targetFile, File.GetCreationTimeUtc(sourceFile));
			File.SetLastWriteTimeUtc(targetFile, File.GetLastWriteTimeUtc(sourceFile));
		}
	}

	private void UpdateStatus()
	{
		_progressTask.Status = string.Join(
			" / ",
			[$"{Math.Ceiling(_progressTask.Completed / (double)MegaByte)} MB", $"{Math.Ceiling(_progressTask.Total / (double)MegaByte)} MB"]
		);
	}
}
