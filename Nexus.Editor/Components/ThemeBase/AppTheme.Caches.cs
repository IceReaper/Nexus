using Godot;
using System.Globalization;

namespace Nexus.Editor.Components.ThemeBase;

public partial class AppTheme
{
	private readonly Dictionary<string, StyleBoxFlat> _boxesCache = [];
	private readonly Dictionary<string, StyleBoxLine> _linesCache = [];
	private readonly Dictionary<string, StyleBoxEmpty> _emptiesCache = [];

	private StyleBoxFlat GetBackground(Color? color, int padding = 0, Color? border = null)
	{
		return GetBackground(color, padding, padding, padding, padding, border);
	}

	private StyleBoxFlat GetBackground(Color? color, int paddingTopBottom, int paddingLeftRight, Color? border = null)
	{
		return GetBackground(color, paddingTopBottom, paddingLeftRight, paddingTopBottom, paddingLeftRight, border);
	}

	private StyleBoxFlat GetBackground(Color? color, int paddingTop, int paddingRight, int paddingBottom, int paddingLeft, Color? border = null)
	{
		var key = string.Join("|", [color?.ToHtml(), paddingTop, paddingRight, paddingBottom, paddingLeft, border?.ToHtml()]);

		if (_boxesCache.TryGetValue(key, out var value))
			return value;

		value = new StyleBoxFlat
		{
			AntiAliasing = false,
			BgColor = color ?? Colors.Transparent,
			ContentMarginTop = paddingTop,
			ContentMarginRight = paddingRight,
			ContentMarginBottom = paddingBottom,
			ContentMarginLeft = paddingLeft
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
		var key = string.Join("|", [color.ToHtml()]);

		if (_linesCache.TryGetValue(key, out var value))
			return value;

		value = new StyleBoxLine { Color = color };

		_linesCache.Add(key, value);

		return value;
	}

	private StyleBoxEmpty GetEmpty(int padding = 0)
	{
		return GetEmpty(padding, padding, padding, padding);
	}

	private StyleBoxEmpty GetEmpty(int paddingTopBottom, int paddingLeftRight)
	{
		return GetEmpty(paddingTopBottom, paddingLeftRight, paddingTopBottom, paddingLeftRight);
	}

	private StyleBoxEmpty GetEmpty(int paddingTop, int paddingRight, int paddingBottom, int paddingLeft)
	{
		var key = string.Join("|", new[] { paddingTop, paddingRight, paddingBottom, paddingLeft }.Select(static e => e.ToString(CultureInfo.InvariantCulture)));

		if (_emptiesCache.TryGetValue(key, out var value))
			return value;

		value = new StyleBoxEmpty
		{
			ContentMarginTop = paddingTop, ContentMarginRight = paddingRight, ContentMarginBottom = paddingBottom, ContentMarginLeft = paddingLeft
		};

		_emptiesCache.Add(key, value);

		return value;
	}
}
