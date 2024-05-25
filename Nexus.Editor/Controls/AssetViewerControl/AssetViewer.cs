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
			treeEntry.Label.Text = name;
			TreeRoot.AddChild(treeEntry);

			PopulateTreeEntry(treeEntry, fileSystem, string.Empty);
		}
	}

	private void PopulateTreeEntry(TreeEntry parent, FileSystem fileSystem, string path)
	{
		foreach (var directory in fileSystem.ListDirectories(path))
		{
			var treeEntry = (TreeEntry)TreeEntry.Instantiate();
			treeEntry.Label.Text = directory;
			parent.Add(treeEntry);

			PopulateTreeEntry(treeEntry, fileSystem, $"{path}/{directory}");
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);

		Main.OnProjectChanged -= ProjectChanged;
	}
}
