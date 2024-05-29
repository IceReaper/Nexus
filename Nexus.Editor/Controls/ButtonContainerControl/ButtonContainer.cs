using Godot;

namespace Nexus.Editor.Controls.ButtonContainerControl;

[Tool]
public partial class ButtonContainer : Container
{
	public event Action? Pressed;

	private bool _mouseEntered;

	public ButtonContainer()
	{
		MouseEntered += () =>
		{
			_mouseEntered = true;
			QueueRedraw();
		};

		MouseExited += () =>
		{
			_mouseEntered = false;
			QueueRedraw();
		};
	}

	public override void _GuiInput(InputEvent @event)
	{
		base._GuiInput(@event);

		if (@event is not InputEventMouseButton { ButtonIndex: MouseButton.Left, Pressed: true })
			return;

		Pressed?.Invoke();
	}

	public override Vector2 _GetMinimumSize()
	{
		var children = GetChildren().OfType<Control>().ToArray();

		return children.Length == 0 ? Vector2.Zero : children.Max(static child => child.GetCombinedMinimumSize());
	}

	public override void _Notification(int what)
	{
		if (what != NotificationSortChildren)
			return;

		foreach (var child in GetChildren().OfType<Control>())
			FitChildInRect(child, new Rect2(Vector2.Zero, Size));
	}

	public override void _Draw()
	{
		var variant = _mouseEntered ? "hover" : "normal";
		var styleBox = GetThemeStylebox(variant, HasThemeStylebox(variant, ThemeTypeVariation) ? ThemeTypeVariation : nameof(ButtonContainer));

		styleBox.Draw(GetCanvasItem(), new Rect2(0, 0, Size));
	}
}
