using Godot;
using Nexus.Editor.Extensions;

namespace Nexus.Editor.Controls.AssetViewerControl;

public partial class ContextMenu : PopupMenu
{
	public FileSystemPath? FileSystemPath { get; set; }
	public FileType FileType { get; set; }

	public override void _Ready()
	{
		Visible = true;

		AddItem("Extract", 1, Key.E);

		IdPressed += id =>
		{
			if (id == 1)
				Extract();
		};

		CloseRequested += QueueFree;

		ResetSize();
		this.Jail();
	}

	private void Extract()
	{
		FileSystemPath?.FileSystem.Unpack(FileSystemPath.Path);
	}
}
