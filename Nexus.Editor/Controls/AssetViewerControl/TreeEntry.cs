using Godot;
using LibNexus.Files;

namespace Nexus.Editor.Controls.AssetViewerControl;

public partial class TreeEntry : Control
{
	[Export]
	public required Button Button { get; set; }

	[Export]
	public required TextureRect IconCollapsed { get; set; }

	[Export]
	public required TextureRect IconExpanded { get; set; }

	[Export]
	public required TextureRect IconNoChildren { get; set; }

	[Export]
	public required Control ChildrenRoot { get; set; }

	[Export]
	public required Control Children { get; set; }

	public AssetViewer? AssetViewer { get; set; }

	public FileSystem? FileSystem { get; set; }
	public string Path { get; set; } = string.Empty;
	public Action<TreeEntry>? PopulateChildren { get; set; }

	private bool _populated;

	public override void _Ready()
	{
		Button.Pressed += Select;
		Button.GuiInput += ExpandOrCollapse;
		IconCollapsed.GuiInput += Expand;
		IconExpanded.GuiInput += Collapse;

		if (FileSystem?.ListDirectories(Path).Length == 0)
			return;

		IconCollapsed.Visible = true;
		IconNoChildren.Visible = false;
	}

	private void Select()
	{
		if (AssetViewer != null)
			AssetViewer.SelectedDirectory = this;
	}

	private void ExpandOrCollapse(InputEvent @event)
	{
		if (@event is not InputEventMouseButton { ButtonIndex: MouseButton.Left, DoubleClick: true })
			return;

		if (!_populated)
		{
			PopulateChildren?.Invoke(this);
			_populated = true;
		}

		if (IconNoChildren.Visible)
			return;

		var collapse = ChildrenRoot.Visible;

		IconCollapsed.Visible = collapse;
		IconExpanded.Visible = !collapse;
		ChildrenRoot.Visible = !collapse;
	}

	private void Expand(InputEvent @event)
	{
		if (@event is not InputEventMouseButton { ButtonIndex: MouseButton.Left })
			return;

		if (!_populated)
		{
			PopulateChildren?.Invoke(this);
			_populated = true;
		}

		IconCollapsed.Visible = false;
		IconExpanded.Visible = true;
		ChildrenRoot.Visible = true;
	}

	private void Collapse(InputEvent @event)
	{
		if (@event is not InputEventMouseButton { ButtonIndex: MouseButton.Left })
			return;

		IconCollapsed.Visible = true;
		IconExpanded.Visible = false;
		ChildrenRoot.Visible = false;
	}
}
