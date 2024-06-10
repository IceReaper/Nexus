using System.Diagnostics;

namespace LibNexus.Editor.Executables;

public static class ExecutableRunner
{
	// TODO refactor to start from memory
	public static Process? Run(byte[] exeBuffer, string targetPath, string arguments = "")
	{
		var tempFile = targetPath[..^4] + ".tmp.exe";
		File.WriteAllBytes(tempFile, exeBuffer);

		var fileName = tempFile;

		if (OperatingSystem.IsLinux())
		{
			arguments = $"{tempFile} {arguments}";
			fileName = "wine";
		}

		var process = Process.Start(new ProcessStartInfo { FileName = fileName, Arguments = arguments, WorkingDirectory = Path.GetDirectoryName(targetPath) });

		if (process == null)
			return null;

		process.Exited += (_, _) =>
		{
			process.WaitForExit();
			File.Delete(tempFile);
		};

		return process;
	}
}
