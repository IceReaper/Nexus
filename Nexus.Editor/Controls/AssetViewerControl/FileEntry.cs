using Godot;

namespace Nexus.Editor.Controls.AssetViewerControl;

public partial class FileEntry : Control
{
	[Export]
	public required Label Label { get; set; }
}
