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
	public PackedScene? ContextMenu { get; set; }

	public FileSystem? FileSystem { get; set; }
	public string Path { get; set; } = string.Empty;
	public Action<TreeEntry>? PopulateChildren { get; set; }

	private bool _populated;

	public override void _Ready()
	{
		Button.Pressed += Select;
		Button.GuiInput += OnGuiInput;
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

	private void OnGuiInput(InputEvent @event)
	{
		if (@event is not InputEventMouseButton { Pressed: true } eventMouseButton)
			return;

		switch (eventMouseButton)
		{
			case { ButtonIndex: MouseButton.Left, DoubleClick: true }:
			{
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

				break;
			}

			case { ButtonIndex: MouseButton.Right }:
			{
				if (ContextMenu == null)
					return;

				var contextMenu = (ContextMenu)ContextMenu.Instantiate();
				contextMenu.Position = eventMouseButton.GlobalPosition;
				contextMenu.FileSystem = FileSystem;
				contextMenu.Path = Path;
				contextMenu.FileType = FileType.Directory;

				AddChild(contextMenu);

				break;
			}
		}
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
