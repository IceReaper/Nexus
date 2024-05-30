using Godot;
using Nexus.Editor.Controls.MainControl;

namespace Nexus.Editor.Controls.AssetViewerControl;

public partial class AssetViewer : Control
{
	[Export]
	public required Main Main { get; set; }

	[Export]
	public required Control TreeRoot { get; set; }

	[Export]
	public required PackedScene TreeEntry { get; set; }

	[Export]
	public required Control IconsRoot { get; set; }

	[Export]
	public required PackedScene IconEntry { get; set; }

	[Export]
	public required LineEdit FilterInput { get; set; }

	private FileSystemPath? _currentPath;

	public FileSystemPath? CurrentPath
	{
		get => _currentPath;

		set
		{
			_currentPath = value;
			UpdateTree();
			RebuildIcons();
		}
	}

	private string _filter = string.Empty;

	public string Filter
	{
		get => _filter;

		set
		{
			_filter = value;
			UpdateIcons();
		}
	}

	public override void _Ready()
	{
		Main.OnProjectChanged += ProjectChanged;
		FilterInput.TextChanged += filter => Filter = filter;
	}

	private void ProjectChanged()
	{
		_currentPath = null;
		_filter = string.Empty;

		RebuildTree();
		RebuildIcons();
	}

	private void RebuildTree()
	{
		// TODO background task
		foreach (var child in TreeRoot.GetChildren())
			child.QueueFree();

		if (Main.Project == null)
			return;

		foreach (var (name, fileSystem) in Main.Project.FileSystems)
		{
			var treeEntry = (TreeEntry)TreeEntry.Instantiate();
			treeEntry.AssetViewer = this;
			treeEntry.FileSystemPath = new FileSystemPath(fileSystem, string.Empty);
			treeEntry.Button.Text = name;

			RebuildTreeEntry(treeEntry);
			TreeRoot.AddChild(treeEntry);
		}
	}

	private void RebuildTreeEntry(TreeEntry parent)
	{
		if (parent.FileSystemPath == null)
			return;

		foreach (var directory in parent.FileSystemPath.FileSystem.ListDirectories(parent.FileSystemPath.Path))
		{
			var treeEntry = (TreeEntry)TreeEntry.Instantiate();
			treeEntry.AssetViewer = this;

			treeEntry.FileSystemPath = parent.FileSystemPath with
			{
				Path = string.IsNullOrEmpty(parent.FileSystemPath.Path) ? directory : $"{parent.FileSystemPath.Path}/{directory}"
			};

			treeEntry.Button.Text = directory;

			RebuildTreeEntry(treeEntry);
			parent.Children.AddChild(treeEntry);
		}
	}

	private void UpdateTree()
	{
		foreach (var child in TreeRoot.GetChildren().OfType<TreeEntry>())
			UpdateTreeEntry(child);
	}

	private void UpdateTreeEntry(TreeEntry treeEntry)
	{
		var buttonPressed = treeEntry.Button.ButtonPressed;

		if (CurrentPath == null)
			buttonPressed = false;
		else if (treeEntry.FileSystemPath != null)
		{
			if (treeEntry.FileSystemPath.FileSystem != CurrentPath.FileSystem)
				buttonPressed = false;
			else if (!CurrentPath.Path.StartsWith(treeEntry.FileSystemPath.Path, StringComparison.OrdinalIgnoreCase))
				buttonPressed = false;
			else
				buttonPressed = true;
		}

		if (!buttonPressed && !treeEntry.Button.ButtonPressed)
			return;

		treeEntry.Button.ButtonPressed = buttonPressed;

		foreach (var child in treeEntry.Children.GetChildren().OfType<TreeEntry>())
			UpdateTreeEntry(child);
	}

	private void RebuildIcons()
	{
		// TODO background task
		foreach (var child in IconsRoot.GetChildren())
			child.QueueFree();

		if (Main.Project == null)
			return;

		if (CurrentPath == null)
		{
			foreach (var (name, fileSystem) in Main.Project.FileSystems)
			{
				var iconEntry = (IconEntry)IconEntry.Instantiate();
				iconEntry.AssetViewer = this;
				iconEntry.FileSystemPath = new FileSystemPath(fileSystem, string.Empty);
				iconEntry.FileType = FileType.Directory;
				iconEntry.Label.Text = name;
				IconsRoot.AddChild(iconEntry);
			}
		}
		else
		{
			var iconEntry = (IconEntry)IconEntry.Instantiate();
			iconEntry.AssetViewer = this;

			if (string.IsNullOrEmpty(CurrentPath.Path))
				iconEntry.FileSystemPath = null;
			else if (CurrentPath.Path.Contains('/', StringComparison.Ordinal))
				iconEntry.FileSystemPath = CurrentPath with { Path = CurrentPath.Path[..CurrentPath.Path.LastIndexOf('/')] };
			else
				iconEntry.FileSystemPath = CurrentPath with { Path = string.Empty };

			iconEntry.FileType = FileType.ParentDirectory;
			iconEntry.Label.Text = "..";
			IconsRoot.AddChild(iconEntry);

			foreach (var directory in CurrentPath.FileSystem.ListDirectories(CurrentPath.Path))
			{
				iconEntry = (IconEntry)IconEntry.Instantiate();
				iconEntry.AssetViewer = this;
				iconEntry.FileSystemPath = CurrentPath with { Path = string.IsNullOrEmpty(CurrentPath.Path) ? directory : $"{CurrentPath.Path}/{directory}" };
				iconEntry.FileType = FileType.Directory;
				iconEntry.Label.Text = directory;
				IconsRoot.AddChild(iconEntry);
			}

			foreach (var file in CurrentPath.FileSystem.ListFiles(CurrentPath.Path))
			{
				var fileType = Path.GetExtension(file) switch
				{
					".m3" => FileType.ComplexModel,
					".i3" => FileType.SimpleModel,
					".tex" => FileType.Texture,
					".dgn" => FileType.Dungeon,
					".wem" => FileType.Sound,
					".xml" => FileType.Ui,
					".tbl" => FileType.Table,
					".area" => FileType.Area,
					".map" => FileType.Map,
					".sho" => FileType.Shader,
					".sky" => FileType.Sky,
					".lua" => FileType.Script,
					".bin" => FileType.Translations,
					".bnk" or ".bk2" => FileType.Video,
					_ => FileType.Unknown
				};

				iconEntry = (IconEntry)IconEntry.Instantiate();
				iconEntry.AssetViewer = this;
				iconEntry.FileSystemPath = CurrentPath with { Path = string.IsNullOrEmpty(CurrentPath.Path) ? file : $"{CurrentPath.Path}/{file}" };
				iconEntry.FileType = fileType;
				iconEntry.Label.Text = file;
				IconsRoot.AddChild(iconEntry);
			}
		}

		UpdateIcons();
	}

	private void UpdateIcons()
	{
		foreach (var child in IconsRoot.GetChildren().OfType<IconEntry>())
		{
			if (child.FileType == FileType.ParentDirectory)
				continue;

			if (child.FileSystemPath != null)
				child.Visible = Path.GetFileName(child.FileSystemPath.Path).Contains(Filter, StringComparison.OrdinalIgnoreCase);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);

		if (disposing)
			Main.OnProjectChanged -= ProjectChanged;
	}
}
