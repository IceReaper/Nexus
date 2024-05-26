using Godot;

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

	public required AssetViewer AssetViewer { get; set; }
	public required string FileSystem { get; set; }
	public required string Path { get; set; }

	public override void _Ready()
	{
		Button.Pressed += Select;
		Button.GuiInput += ExpandOrCollapse;
		IconCollapsed.GuiInput += Expand;
		IconExpanded.GuiInput += Collapse;
	}

	private void Select()
	{
		AssetViewer.SelectedDirectory = this;
	}

	// TODO this function does not trigger?!
	private void ExpandOrCollapse(InputEvent @event)
	{
		if (@event is not InputEventMouseButton { ButtonIndex: MouseButton.Left, DoubleClick: true })
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

	public void Add(TreeEntry child)
	{
		Children.AddChild(child);

		if (!IconNoChildren.Visible)
			return;

		IconNoChildren.Visible = false;
		IconCollapsed.Visible = true;
	}
}
