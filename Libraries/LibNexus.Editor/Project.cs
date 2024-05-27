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

	private Project(string projectFilePath)
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

	public static async Task<Project> Load(string projectFilePath, Progress progress, CancellationToken cancellationToken)
	{
		var project = new Project(projectFilePath);

		var distPath = Path.Combine(project._rootPath, DistDirectory);
		var bootstrapPath = Path.Combine(distPath, "Bootstrap");
		var patchPath = Path.Combine(distPath, "Patch");

		var languages = Directory.GetFiles(patchPath, "ClientData*.index")
			.Select(Path.GetFileNameWithoutExtension)
			.OfType<string>()
			.Where(static file => file.Length == 12)
			.Select(static file => file[^2..])
			.ToArray();

		progress.Total = (ulong)(2 + languages.Length);

		progress.Title = "Loading project: LauncherData";
		var launcherProgress = new Progress();
		progress.Children.Add(launcherProgress);

		project.FileSystems.Add(
			"LauncherData",
			await FileSystem.Create(launcherProgress, Path.Combine(bootstrapPath, "LauncherData"), true, null, cancellationToken)
		);

		progress.Children.Remove(launcherProgress);
		progress.Completed++;

		var clientProgress = new Progress();
		progress.Children.Add(clientProgress);
		progress.Title = "Loading project: ClientData";

		project.FileSystems.Add("ClientData", await FileSystem.Create(clientProgress, Path.Combine(patchPath, "ClientData"), true, "Data", cancellationToken));

		progress.Children.Remove(clientProgress);
		progress.Completed++;

		foreach (var language in languages)
		{
			progress.Title = $"Loading project: ClientData{language}";
			var languageProgress = new Progress();
			progress.Children.Add(languageProgress);

			// TODO set the right folder!
			project.FileSystems.Add(
				$"ClientData{language}",
				await FileSystem.Create(languageProgress, Path.Combine(patchPath, $"ClientData{language}"), true, null, cancellationToken)
			);

			progress.Children.Remove(languageProgress);
			progress.Completed++;
		}

		// TODO start a background task to scan the src dir and update the dist files if required.
		Console.WriteLine(SrcDirectory);

		return project;
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
