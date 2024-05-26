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
			treeEntry.Path = $"{parent.Path}/{directory}";
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

		foreach (var file in _selectedDirectory.FileSystem.ListFiles(_selectedDirectory.Path))
		{
			var fileEntry = (FileEntry)FileEntry.Instantiate();
			fileEntry.File = file;
			FilesRoot.AddChild(fileEntry);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);

		Main.OnProjectChanged -= ProjectChanged;

		_selectedDirectory?.Dispose();
	}
}
