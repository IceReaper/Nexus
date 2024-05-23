using Godot;

namespace Nexus.Editor.Components.ThemeBase;

public partial class AppTheme
{
	private const int Padding = 5;

	private const int FontSize = 14;
	private const int FontSizeSmall = 12;

	private static readonly Font Font;

	private static readonly Color BackgroundDark = new(0x2d2f3aff);
	private static readonly Color Background = new(0x32333dff);
	private static readonly Color BackgroundLight = new(0x373740ff);
	private static readonly Color Border = new(0x4c4b53ff);

	private static readonly Color Primary = new(0x5b4be3ff);
	private static readonly Color Info = new(0x3299ffff);
	private static readonly Color Success = new(0x0bba83ff);
	private static readonly Color Warning = new(0xffaa00ff);
	private static readonly Color Error = new(0xf64e62ff);

	private static readonly Color TextPrimary = new(0xb2b2b2ff);
	private static readonly Color TextActive = new(0xffffffff);
	private static readonly Color TextDisabled = new(0x666666ff);

	static AppTheme()
	{
		Font = ResourceLoader.Load<Font>("res://Assets/Fonts/Roboto-Regular.ttf");
	}
}
