using Godot;
using Nexus.Editor.Controls.ThemeBaseControl;
using Nexus.Editor.Extensions;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Nexus.Editor.Controls.AboutControl;

public partial class About : Control
{
	[Export]
	public required Window Window { get; set; }

	[Export]
	public required Label Version { get; set; }

	[Export]
	public required Label Date { get; set; }

	[Export]
	public required Label Commit { get; set; }

	[Export]
	public required RichTextLabel Repository { get; set; }

	[GeneratedRegex(@"\w+\/\w+(?=\.git)")]
	private static partial Regex GitHubRepoRegex();

	public override void _Ready()
	{
		var repositoryName = GitHubRepoRegex().Match(ThisAssembly.Git.RepositoryUrl).Value;

		Version.Text = $"{(string.IsNullOrEmpty(ThisAssembly.Git.Tag) ? ThisAssembly.Git.Branch : ThisAssembly.Git.Tag)}.{ThisAssembly.Git.Commits}";
		Date.Text = DateTime.Parse(ThisAssembly.Git.CommitDate, CultureInfo.InvariantCulture).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
		Commit.Text = ThisAssembly.Git.Commit;
		Repository.Text = $"[color=#{AppTheme.TextActive.ToHtml()}][url=https://github.com/{repositoryName}]{repositoryName}[/url][/color]";

		Repository.MetaClicked += static link => OS.ShellOpen(link.AsString());

		Window.ResetSize();
		Window.CloseRequested += Close;
	}

	public override void _Process(double delta)
	{
		Window.Jail();
	}

	private void Close()
	{
		QueueFree();
	}
}
