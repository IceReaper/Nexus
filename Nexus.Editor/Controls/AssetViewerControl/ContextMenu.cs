using Godot;
using LibNexus.Files;
using Nexus.Editor.Extensions;

namespace Nexus.Editor.Controls.AssetViewerControl;

public partial class ContextMenu : PopupMenu
{
	public FileSystem? FileSystem { get; set; }
	public string Path { get; set; } = string.Empty;
	public FileType FileType { get; set; }

	public override void _Ready()
	{
		AddItem("Extract", 1, Key.E);

		IdPressed += id =>
		{
			if (id == 1)
				Extract();
		};

		CloseRequested += Free;

		ResetSize();
		this.Jail();
	}

	private void Extract()
	{
		FileSystem?.Unpack(Path);
	}
}
