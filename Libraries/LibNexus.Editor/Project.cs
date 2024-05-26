using LibNexus.Core;
using LibNexus.Editor.Executables;
using LibNexus.Files;
using System.Diagnostics;

namespace LibNexus.Editor;

public class Project
{
	public const string DistDirectory = "dist";
	private const string SrcDirectory = "src";
	private const string ProjectFile = "project.nexus";

	private const string LauncherPath = "WildStar.exe";
	private const string ClientPath = "Client64/WildStar64.exe";

	private readonly string _rootPath;

	public Dictionary<string, FileSystem> FileSystems { get; } = [];

	public Project(string projectFilePath)
	{
		_rootPath = Path.GetDirectoryName(projectFilePath) ?? string.Empty;
	}

	public static string Create(string rootPath)
	{
		if (!Directory.Exists(rootPath))
			Directory.CreateDirectory(rootPath);

		var projectFilePath = Path.Combine(rootPath, ProjectFile);

		File.Create(projectFilePath);

		File.WriteAllBytes(Path.Combine(rootPath, ".gitignore"), "/dist/"u8.ToArray());

		return projectFilePath;
	}

	public ProgressTask Load()
	{
		var progressTask = new ProgressTask();
		progressTask.Run(LoadInternal);

		return progressTask;
	}

	private void LoadInternal(ProgressTask progressTask)
	{
		FileSystems.Add("LauncherData", new FileSystem(progressTask, Path.Combine(_rootPath, DistDirectory, "Bootstrap", "LauncherData")));
		FileSystems.Add("ClientData", new FileSystem(progressTask, Path.Combine(_rootPath, DistDirectory, "Patch", "ClientData")));
		FileSystems.Add("ClientDataEN", new FileSystem(progressTask, Path.Combine(_rootPath, DistDirectory, "Patch", "ClientDataEN")));
		FileSystems.Add("ClientDataDE", new FileSystem(progressTask, Path.Combine(_rootPath, DistDirectory, "Patch", "ClientDataDE")));
		FileSystems.Add("ClientDataFR", new FileSystem(progressTask, Path.Combine(_rootPath, DistDirectory, "Patch", "ClientDataFR")));

		// TODO do stuff
		Console.WriteLine(SrcDirectory);
	}

	public static bool ValidateInstallation(string rootPath)
	{
		var launcherPath = Path.Combine(rootPath, LauncherPath);
		var clientPath = Path.Combine(rootPath, ClientPath);

		if (!File.Exists(launcherPath))
			return false;

		if (!File.Exists(clientPath))
			return false;

		var launcher = new LauncherExecutable(launcherPath);
		var client = new ClientExecutable(clientPath);

		return launcher.Validate() && client.Validate();
	}

	public Process Run()
	{
		var clientExecutablePath = Path.Combine(_rootPath, DistDirectory, ClientPath);

		var clientExecutable = new ClientExecutable(clientExecutablePath);
		clientExecutable.EnableBypassLauncher();
		////clientExecutable.EnableLoadUnpackedFiles();

		return ExecutableRunner.Run(
			clientExecutable.Bytes,
			clientExecutablePath,
			"/auth localhost /authNc localhost /lang de /patcher localhost /SettingsKey WildStar /RealmDataCenterId 9"
		) ?? throw new Exception("Failed to start client");
	}
}
