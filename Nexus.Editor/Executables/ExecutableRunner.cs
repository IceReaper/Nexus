using System.Diagnostics;

namespace Nexus.Editor.Executables;

public static class ExecutableRunner
{
	public static Process? Run(byte[] exeBuffer, string targetPath, string arguments = "")
	{
		var tempFile = targetPath[..^4] + ".tmp.exe";
		File.WriteAllBytes(tempFile, exeBuffer);

		var process = Process.Start(new ProcessStartInfo { FileName = tempFile, Arguments = arguments, WorkingDirectory = Path.GetDirectoryName(targetPath) });

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
