using Godot;
using Nexus.Editor.Controls.MainControl;

namespace Nexus.Editor.Controls.AssetViewerControl;

// TODO Files view needs also folders. We should rename it into IconView. Also we need a filter function here as some folders are huge!
public partial class AssetViewer : Control
{
	[Export]
	public required Main Main { get; set; }

	[Export]
	public required Control TreeRoot { get; set; }

	[Export]
	public required PackedScene TreeEntry { get; set; }

	[Export]
	public required Control FilesRoot { get; set; }

	[Export]
	public required PackedScene FileEntry { get; set; }

	private TreeEntry? _selectedDirectory;

	public TreeEntry? SelectedDirectory
	{
		get => _selectedDirectory;

		set
		{
			if (_selectedDirectory != null)
				_selectedDirectory.Button.ButtonPressed = false;

			_selectedDirectory = value;
			UpdateFiles();
		}
	}

	public override void _Ready()
	{
		Main.OnProjectChanged += ProjectChanged;
	}

	private void ProjectChanged()
	{
		foreach (var child in TreeRoot.GetChildren())
			child.Free();

		foreach (var child in FilesRoot.GetChildren())
			child.Free();

		if (Main.Project == null)
			return;

		foreach (var (name, fileSystem) in Main.Project.FileSystems)
		{
			var treeEntry = (TreeEntry)TreeEntry.Instantiate();
			treeEntry.AssetViewer = this;
			treeEntry.FileSystem = fileSystem;
			treeEntry.Path = string.Empty;
			treeEntry.Button.Text = name;
			treeEntry.PopulateChildren = PopulateTreeEntry;
			TreeRoot.AddChild(treeEntry);
		}
	}

	private void PopulateTreeEntry(TreeEntry parent)
	{
		if (parent.FileSystem == null)
			return;

		foreach (var directory in parent.FileSystem.ListDirectories(parent.Path))
		{
			var treeEntry = (TreeEntry)TreeEntry.Instantiate();
			treeEntry.AssetViewer = this;
			treeEntry.FileSystem = parent.FileSystem;
			treeEntry.Path = string.IsNullOrEmpty(parent.Path) ? directory : $"{parent.Path}/{directory}";
			treeEntry.Button.Text = directory;
			treeEntry.PopulateChildren = PopulateTreeEntry;
			parent.Children.AddChild(treeEntry);
		}
	}

	private void UpdateFiles()
	{
		foreach (var child in FilesRoot.GetChildren())
			child.Free();

		if (_selectedDirectory == null || Main.Project == null)
			return;

		_selectedDirectory.Button.ButtonPressed = true;

		if (_selectedDirectory.FileSystem == null)
			return;

		foreach (var directory in _selectedDirectory.FileSystem.ListDirectories(_selectedDirectory.Path))
		{
			var fileEntry = (FileEntry)FileEntry.Instantiate();
			fileEntry.AssetViewer = this;
			fileEntry.FileSystem = _selectedDirectory.FileSystem;
			fileEntry.Path = string.IsNullOrEmpty(_selectedDirectory.Path) ? directory : $"{_selectedDirectory.Path}/{directory}";
			fileEntry.FileType = FileType.Directory;
			FilesRoot.AddChild(fileEntry);
		}

		foreach (var file in _selectedDirectory.FileSystem.ListFiles(_selectedDirectory.Path))
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

			var fileEntry = (FileEntry)FileEntry.Instantiate();
			fileEntry.AssetViewer = this;
			fileEntry.FileSystem = _selectedDirectory.FileSystem;
			fileEntry.Path = string.IsNullOrEmpty(_selectedDirectory.Path) ? file : $"{_selectedDirectory.Path}/{file}";
			fileEntry.FileType = fileType;
			FilesRoot.AddChild(fileEntry);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);

		if (!disposing)
			return;

		Main.OnProjectChanged -= ProjectChanged;

		_selectedDirectory?.Dispose();
	}
}
