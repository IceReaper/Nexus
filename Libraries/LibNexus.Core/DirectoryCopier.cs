using LibNexus.Core.Extensions;

namespace LibNexus.Core;

public class DirectoryCopier
{
	public const int MegaByte = 1024 * 1024;

	public ulong TotalBytes { get; private set; }
	public ulong CopiedBytes { get; private set; }
	public bool Complete { get; private set; }

	private readonly Dictionary<string, string> _tasks = [];

	public void Add(string source, string target)
	{
		Measure(source);

		_tasks.Add(source, target);
	}

	private void Measure(string path)
	{
		foreach (var directory in Directory.GetDirectories(path))
			Measure(directory);

		foreach (var file in Directory.GetFiles(path))
			TotalBytes += (ulong)new FileInfo(file).Length;
	}

	public void Run()
	{
		Task.Run(RunInternal);
	}

	private void RunInternal()
	{
		foreach (var (source, target) in _tasks)
			Copy(source, target);

		Complete = true;
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

				CopiedBytes += amount;
			}

			File.SetCreationTimeUtc(targetFile, File.GetCreationTimeUtc(sourceFile));
			File.SetLastWriteTimeUtc(targetFile, File.GetLastWriteTimeUtc(sourceFile));
		}
	}
}
