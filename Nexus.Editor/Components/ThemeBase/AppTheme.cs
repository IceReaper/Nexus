using Godot;

namespace Nexus.Editor.Components.ThemeBase;

public partial class AppTheme : Theme
{
	public AppTheme()
	{
		Panels();
		BoxContainers();
		Margins();
		Separators();
		SplitContainers();
		Labels();
		ScrollBars();
		MenuBars();
		PopupMenus();
	}

	private void Panels()
	{
		SetStylebox("panel", nameof(Panel), new StyleBoxEmpty());
		SetStylebox("panel", nameof(PanelContainer), new StyleBoxEmpty());

		SetTypeVariation("Background", nameof(PanelContainer));
		SetStylebox("panel", "Background", GetBackground(Background));

		SetTypeVariation("Surface", nameof(PanelContainer));
		SetStylebox("panel", "Surface", GetBackground(BackgroundLight));

		SetTypeVariation("Border", nameof(PanelContainer));
		SetStylebox("panel", "Border", GetBackground(null, 0, Border));
	}

	private void BoxContainers()
	{
		SetConstant("separation", nameof(HBoxContainer), 0);
		SetConstant("separation", nameof(VBoxContainer), 0);
	}

	private void Margins()
	{
		SetTypeVariation("All", nameof(MarginContainer));
		SetConstant("margin_top", "All", Padding);
		SetConstant("margin_right", "All", Padding);
		SetConstant("margin_bottom", "All", Padding);
		SetConstant("margin_left", "All", Padding);

		SetTypeVariation("Top", nameof(MarginContainer));
		SetConstant("margin_top", "Top", Padding);

		SetTypeVariation("Right", nameof(MarginContainer));
		SetConstant("margin_right", "Right", Padding);

		SetTypeVariation("Left", nameof(MarginContainer));
		SetConstant("margin_left", "Left", Padding);
	}

	private void Separators()
	{
		SetConstant("separation", nameof(HSeparator), 1);
		SetConstant("separation", nameof(VSeparator), 1);

		SetStylebox("separator", nameof(HSeparator), GetLine(Border));
		SetStylebox("separator", nameof(VSeparator), GetLine(Border));
	}

	private void SplitContainers()
	{
		SetConstant("separation", nameof(HSplitContainer), 0);
		SetConstant("separation", nameof(VSplitContainer), 0);

		SetIcon("grabber", nameof(HSplitContainer), new ImageTexture());
		SetIcon("grabber", nameof(VSplitContainer), new ImageTexture());
	}

	private void Labels()
	{
		SetFont("font", nameof(Label), Font);
		SetFontSize("font_size", nameof(Label), FontSize);
	}

	private void ScrollBars()
	{
		SetStylebox("scroll", nameof(HScrollBar), GetBackground(BackgroundDark, Padding, 0));
		SetStylebox("scroll", nameof(VScrollBar), GetBackground(BackgroundDark, 0, Padding));
		SetStylebox("grabber", nameof(HScrollBar), GetBackground(BackgroundLight));
		SetStylebox("grabber", nameof(VScrollBar), GetBackground(BackgroundLight));
		SetStylebox("grabber_highlight", nameof(HScrollBar), GetBackground(Border));
		SetStylebox("grabber_highlight", nameof(VScrollBar), GetBackground(Border));
		SetStylebox("grabber_pressed", nameof(HScrollBar), GetBackground(Border));
		SetStylebox("grabber_pressed", nameof(VScrollBar), GetBackground(Border));
	}

	private void MenuBars()
	{
		SetConstant("h_separation", nameof(MenuBar), 0);

		SetFont("font", nameof(MenuBar), Font);
		SetFontSize("font_size", nameof(MenuBar), FontSize);

		SetColor("font_color", nameof(MenuBar), TextPrimary);
		SetColor("font_pressed_color", nameof(MenuBar), TextActive);
		SetColor("font_hover_color", nameof(MenuBar), TextActive);
		SetColor("font_focus_color", nameof(MenuBar), TextActive);
		SetColor("font_hover_pressed_color", nameof(MenuBar), TextActive);
		SetColor("font_disabled_color", nameof(MenuBar), TextDisabled);

		SetStylebox("normal", nameof(MenuBar), GetEmpty(Padding, Padding));
		SetStylebox("hover", nameof(MenuBar), GetBackground(Primary, Padding, Padding));
		SetStylebox("pressed", nameof(MenuBar), GetBackground(Primary, Padding, Padding));
		SetStylebox("disabled", nameof(MenuBar), GetEmpty(Padding, Padding));
	}

	private void PopupMenus()
	{
		SetFont("font", nameof(PopupMenu), Font);
		SetFontSize("font_size", nameof(PopupMenu), FontSize);

		SetFont("font_separator", nameof(PopupMenu), Font);
		SetFontSize("font_separator_size", nameof(PopupMenu), FontSizeSmall);

		SetColor("font_color", nameof(PopupMenu), TextPrimary);
		SetColor("font_accelerator_color", nameof(PopupMenu), TextActive);
		SetColor("font_disabled_color", nameof(PopupMenu), TextDisabled);
		SetColor("font_hover_color", nameof(PopupMenu), TextActive);
		SetColor("font_separator_color", nameof(PopupMenu), TextDisabled);

		SetConstant("item_start_padding", nameof(PopupMenu), Padding);
		SetConstant("item_end_padding", nameof(PopupMenu), Padding);

		SetStylebox("panel", nameof(PopupMenu), GetBackground(BackgroundLight, 0, Border));
		SetStylebox("hover", nameof(PopupMenu), GetBackground(Primary, Padding));
		SetStylebox("separator", nameof(PopupMenu), GetLine(TextDisabled));
		SetStylebox("labeled_separator_left", nameof(PopupMenu), GetLine(TextDisabled));
		SetStylebox("labeled_separator_right", nameof(PopupMenu), GetLine(TextDisabled));
	}
}
