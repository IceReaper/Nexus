using Godot;

namespace Nexus.Editor.Theme;

public partial class AppTheme
{
	private readonly Dictionary<string, StyleBoxFlat> _boxesCache = [];
	private readonly Dictionary<string, StyleBoxLine> _linesCache = [];
	private readonly Dictionary<string, StyleBoxEmpty> _emptiesCache = [];
	private readonly Dictionary<string, Texture2D> _iconsCache = [];

	private StyleBoxFlat GetBackground(Color color, Sides padding = default, Color? border = null, Sides expandMargin = default)
	{
		var key = string.Join("|", [color, padding, border, expandMargin]);

		if (_boxesCache.TryGetValue(key, out var value))
			return value;

		value = new StyleBoxFlat
		{
			AntiAliasing = false,
			BgColor = color,
			ContentMarginTop = padding.Top,
			ContentMarginRight = padding.Right,
			ContentMarginBottom = padding.Bottom,
			ContentMarginLeft = padding.Left,
			ExpandMarginTop = expandMargin.Top,
			ExpandMarginRight = expandMargin.Right,
			ExpandMarginBottom = expandMargin.Bottom,
			ExpandMarginLeft = expandMargin.Left
		};

		if (border != null)
		{
			value.BorderColor = border.Value;
			value.ContentMarginTop += value.BorderWidthTop = 1;
			value.ContentMarginRight += value.BorderWidthRight = 1;
			value.ContentMarginBottom += value.BorderWidthBottom = 1;
			value.ContentMarginLeft += value.BorderWidthLeft = 1;
		}

		_boxesCache.Add(key, value);

		return value;
	}

	private StyleBoxLine GetLine(Color color)
	{
		var key = string.Join("|", new[] { color });

		if (_linesCache.TryGetValue(key, out var value))
			return value;

		value = new StyleBoxLine { Color = color };

		_linesCache.Add(key, value);

		return value;
	}

	private StyleBoxEmpty GetEmpty(Sides padding = default)
	{
		var key = string.Join("|", padding);

		if (_emptiesCache.TryGetValue(key, out var value))
			return value;

		value = new StyleBoxEmpty
		{
			ContentMarginTop = padding.Top, ContentMarginRight = padding.Right, ContentMarginBottom = padding.Bottom, ContentMarginLeft = padding.Left
		};

		_emptiesCache.Add(key, value);

		return value;
	}

	private Texture2D GetIcon(Color color, int size)
	{
		var key = string.Join("|", [color, size]);

		if (_iconsCache.TryGetValue(key, out var value))
			return value;

		if (size == 0)
			value = new ImageTexture();
		else
		{
			var data = new byte[size * size * 4];
			var pixel = new[] { (byte)color.R8, (byte)color.G8, (byte)color.B8, (byte)color.A8 };

			for (var i = 0; i < size * size; i++)
				Array.Copy(pixel, 0, data, i * 4, 4);

			value = ImageTexture.CreateFromImage(Image.CreateFromData(size, size, false, Image.Format.Rgba8, data));
		}

		_iconsCache.Add(key, value);

		return value;
	}
}
