using Godot;
using LibNexus.Files;
using Nexus.Editor.Extensions;

namespace Nexus.Editor.Controls.AssetViewerControl;

public partial class ContextMenu : Control
{
	[Export]
	public required PopupMenu PopupMenu { get; set; }

	public FileSystem? FileSystem { get; set; }
	public string Path { get; set; } = string.Empty;
	public FileType FileType { get; set; }

	public override void _Ready()
	{
		PopupMenu.Position = new Vector2I((int)Position.X, (int)Position.Y);

		PopupMenu.AddItem("Extract", 1, Key.E);

		PopupMenu.IdPressed += id =>
		{
			if (id == 1)
				Extract();
		};

		PopupMenu.CloseRequested += Free;

		PopupMenu.ResetSize();
		PopupMenu.Jail();
	}

	private void Extract()
	{
		FileSystem?.Unpack(Path);
	}
}
