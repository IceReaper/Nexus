using Godot;
using Nexus.Editor.Controls.ThemeBaseControl;

namespace Nexus.Editor.Extensions;

public static class WindowExtensions
{
	public static void Jail(this Window window, Control? jail = null)
	{
		var position = jail?.Position ?? default;
		var size = jail?.Size ?? window.GetParent().GetViewport().GetVisibleRect().Size;

		var min = new Vector2I((int)(position.X + AppTheme.WindowDecorations.Left), (int)(position.Y + AppTheme.WindowDecorations.Top));

		var max = new Vector2I(
			(int)Math.Max(position.X + size.X - window.Size.X - AppTheme.WindowDecorations.Right, min.X),
			(int)Math.Max(position.Y + size.Y - window.Size.Y - AppTheme.WindowDecorations.Bottom, min.Y)
		);

		window.Position = new Vector2I { X = Math.Clamp(window.Position.X, min.X, max.X), Y = Math.Clamp(window.Position.Y, min.Y, max.Y) };
	}
}
