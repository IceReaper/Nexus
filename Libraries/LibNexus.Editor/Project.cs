using LibNexus.Editor.Executables;

namespace LibNexus.Editor;

public class Project
{
	public const string DistDirectory = "dist";
	public const string SrcDirectory = "src";
	public const string ProjectFile = "project.nexus";

	public static readonly string LauncherPath = "WildStar.exe";
	public static readonly string ClientPath = Path.Combine("Client64", "WildStar64.exe");

	public string RootPath { get; }

	public Project(string projectFilePath)
	{
		RootPath = Path.GetDirectoryName(projectFilePath) ?? string.Empty;
	}

	public static Project Create(string rootPath)
	{
		if (!Directory.Exists(rootPath))
			Directory.CreateDirectory(rootPath);

		var projectFilePath = Path.Combine(rootPath, ProjectFile);

		File.Create(projectFilePath);

		File.WriteAllBytes(Path.Combine(rootPath, ".gitignore"), "/dist/"u8.ToArray());

		return new Project(projectFilePath);
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
}
