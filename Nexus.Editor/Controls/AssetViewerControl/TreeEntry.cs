using Godot;
using LibNexus.Files;
using Nexus.Editor.Extensions;

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
		switch (@event)
		{
			case InputEventMouseButton { ButtonIndex: MouseButton.Left, DoubleClick: true }:
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

			// TODO this copy / paste is ugly. Make this whole context menu thing somehow more elegant.
			case InputEventMouseButton { Pressed: true, ButtonIndex: MouseButton.Right } eventMouseButton:
			{
				var popupMenu = new PopupMenu
				{
					Position = new Vector2I((int)eventMouseButton.GlobalPosition.X, (int)eventMouseButton.GlobalPosition.Y), Visible = true
				};

				popupMenu.AddItem("Extract", 1);

				popupMenu.IdPressed += id =>
				{
					if (id == 1)
						FileSystem?.Unpack(Path);
				};

				popupMenu.CloseRequested += () => popupMenu.Free();

				AddChild(popupMenu);

				popupMenu.ResetSize();
				popupMenu.Jail();

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
