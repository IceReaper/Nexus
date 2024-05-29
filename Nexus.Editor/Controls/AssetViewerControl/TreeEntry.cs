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

	public AssetViewer? AssetViewer { get; set; }

	public FileSystemPath? FileSystemPath { get; set; }

	public override void _Ready()
	{
		Button.Pressed += Select;
		Button.GuiInput += OnGuiInput;
		IconCollapsed.GuiInput += Expand;
		IconExpanded.GuiInput += Collapse;

		if (FileSystemPath?.FileSystem.ListDirectories(FileSystemPath.Path).Length == 0)
			return;

		IconCollapsed.Visible = true;
		IconNoChildren.Visible = false;
	}

	private void Select()
	{
		if (AssetViewer != null)
			AssetViewer.CurrentPath = FileSystemPath;
	}

	private void OnGuiInput(InputEvent @event)
	{
		if (@event is not InputEventMouseButton { Pressed: true } eventMouseButton)
			return;

		switch (eventMouseButton)
		{
			case { ButtonIndex: MouseButton.Left, DoubleClick: true }:
			{
				if (IconNoChildren.Visible)
					return;

				var collapse = ChildrenRoot.Visible;

				IconCollapsed.Visible = collapse;
				IconExpanded.Visible = !collapse;
				ChildrenRoot.Visible = !collapse;

				break;
			}

			case { ButtonIndex: MouseButton.Right }:
			{
				AddChild(
					new ContextMenu
					{
						Position = new Vector2I((int)eventMouseButton.GlobalPosition.X, (int)eventMouseButton.GlobalPosition.Y),
						FileSystemPath = FileSystemPath,
						FileType = FileType.Directory
					}
				);

				break;
			}
		}
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
}
