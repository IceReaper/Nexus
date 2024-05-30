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
	public Action<TreeEntry>? GenerateChildren { get; set; }

	private bool _populated;

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

				if (!ChildrenRoot.Visible)
					Expand();
				else
					Collapse();

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
		if (@event is InputEventMouseButton { ButtonIndex: MouseButton.Left })
			Expand();
	}

	private void Expand()
	{
		if (!_populated)
		{
			_populated = true;
			GenerateChildren?.Invoke(this);
		}

		IconCollapsed.Visible = false;
		IconExpanded.Visible = true;
		ChildrenRoot.Visible = true;
	}

	private void Collapse(InputEvent @event)
	{
		if (@event is InputEventMouseButton { ButtonIndex: MouseButton.Left })
			Collapse();
	}

	private void Collapse()
	{
		IconCollapsed.Visible = true;
		IconExpanded.Visible = false;
		ChildrenRoot.Visible = false;
	}
}
