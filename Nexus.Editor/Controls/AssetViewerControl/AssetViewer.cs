using Godot;
using LibNexus.Files;
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

			foreach (var child in FilesRoot.GetChildren())
				child.Free();

			_selectedDirectory = value;

			if (_selectedDirectory == null || Main.Project == null)
				return;

			_selectedDirectory.Button.ButtonPressed = true;

			foreach (var file in Main.Project.FileSystems[_selectedDirectory.FileSystem].ListFiles(_selectedDirectory.Path))
			{
				var fileEntry = (FileEntry)FileEntry.Instantiate();
				fileEntry.Label.Text = file;
				FilesRoot.AddChild(fileEntry);
			}
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
			treeEntry.FileSystem = name;
			treeEntry.Path = string.Empty;
			treeEntry.Button.Text = name;
			TreeRoot.AddChild(treeEntry);

			PopulateTreeEntry(treeEntry, fileSystem, name, string.Empty);
		}
	}

	private void PopulateTreeEntry(TreeEntry parent, FileSystem fileSystem, string name, string path)
	{
		foreach (var directory in fileSystem.ListDirectories(path))
		{
			var treeEntry = (TreeEntry)TreeEntry.Instantiate();
			treeEntry.AssetViewer = this;
			treeEntry.AssetViewer = this;
			treeEntry.FileSystem = name;
			treeEntry.Path = $"{parent.Path}/{directory}";
			treeEntry.Button.Text = directory;
			parent.Add(treeEntry);

			PopulateTreeEntry(treeEntry, fileSystem, name, $"{path}/{directory}");
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);

		Main.OnProjectChanged -= ProjectChanged;

		_selectedDirectory?.Dispose();
	}
}
