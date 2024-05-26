using Godot;

namespace Nexus.Editor.Controls.ThemeBaseControl;

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
		RichTexts();
		ScrollBars();
		Buttons();
		MenuBars();
		PopupMenus();
		Windows();
		ProgressBars();
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
		SetStylebox("panel", "Border", GetBackground(Colors.Transparent, default, Border));
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

		SetTypeVariation("Horizontal", nameof(MarginContainer));
		SetConstant("margin_right", "Horizontal", Padding);
		SetConstant("margin_left", "Horizontal", Padding);

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

		SetIcon("grabber", nameof(HSplitContainer), GetIcon(Colors.Transparent, 0));
		SetIcon("grabber", nameof(VSplitContainer), GetIcon(Colors.Transparent, 0));
	}

	private void Labels()
	{
		SetFont("font", nameof(Label), Font);
		SetFontSize("font_size", nameof(Label), FontSize);
	}

	private void RichTexts()
	{
		SetColor("default_color", nameof(RichTextLabel), TextPrimary);

		SetFont("normal_font", nameof(RichTextLabel), Font);
		SetFontSize("normal_font_size", nameof(RichTextLabel), FontSize);
	}

	private void ScrollBars()
	{
		SetStylebox("scroll", nameof(HScrollBar), GetBackground(BackgroundDark, new Sides(Padding, 0)));
		SetStylebox("scroll", nameof(VScrollBar), GetBackground(BackgroundDark, new Sides(0, Padding)));
		SetStylebox("grabber", nameof(HScrollBar), GetBackground(BackgroundLight));
		SetStylebox("grabber", nameof(VScrollBar), GetBackground(BackgroundLight));
		SetStylebox("grabber_highlight", nameof(HScrollBar), GetBackground(Border));
		SetStylebox("grabber_highlight", nameof(VScrollBar), GetBackground(Border));
		SetStylebox("grabber_pressed", nameof(HScrollBar), GetBackground(Border));
		SetStylebox("grabber_pressed", nameof(VScrollBar), GetBackground(Border));
	}

	private void Buttons()
	{
		SetFont("font", nameof(Button), Font);
		SetFontSize("font_size", nameof(Button), FontSize);

		SetStylebox("normal", nameof(Button), GetBackground(BackgroundDark, new Sides(Padding, Padding * 2)));
		SetStylebox("hover", nameof(Button), GetBackground(BackgroundLight, new Sides(Padding, Padding * 2)));
		SetStylebox("pressed", nameof(Button), GetBackground(BackgroundLight, new Sides(Padding, Padding * 2)));
		SetStylebox("disabled", nameof(Button), GetEmpty(new Sides(Padding, Padding * 2)));
		SetStylebox("focus", nameof(Button), GetBackground(BackgroundLight, new Sides(Padding, Padding * 2)));

		SetColor("font_color", nameof(Button), TextPrimary);
		SetColor("font_pressed_color", nameof(Button), TextActive);
		SetColor("font_hover_color", nameof(Button), TextActive);
		SetColor("font_focus_color", nameof(Button), TextActive);
		SetColor("font_hover_pressed_color", nameof(Button), TextActive);
		SetColor("font_disabled_color", nameof(Button), TextDisabled);

		SetColor("icon_normal_color", nameof(Button), TextPrimary);
		SetColor("icon_pressed_color", nameof(Button), TextActive);
		SetColor("icon_hover_color", nameof(Button), TextActive);
		SetColor("icon_focus_color", nameof(Button), TextActive);
		SetColor("icon_hover_pressed_color", nameof(Button), TextActive);
		SetColor("icon_disabled_color", nameof(Button), TextDisabled);

		SetTypeVariation("Text", nameof(Button));
		SetStylebox("normal", "Text", GetEmpty());
		SetStylebox("hover", "Text", GetBackground(BackgroundLight));
		SetStylebox("pressed", "Text", GetBackground(BackgroundLight));
		SetStylebox("disabled", "Text", GetEmpty());
		SetStylebox("focus", "Text", GetBackground(BackgroundLight));

		SetTypeVariation("Info", nameof(Button));
		SetColor("font_color", "Info", Info);
		SetColor("icon_normal_color", "Info", Info);
		SetStylebox("hover", "Info", GetBackground(Info));
		SetStylebox("pressed", "Info", GetBackground(Info));
		SetStylebox("focus", "Info", GetBackground(Info));

		SetTypeVariation("Success", nameof(Button));
		SetColor("font_color", "Success", Success);
		SetColor("icon_normal_color", "Success", Success);
		SetStylebox("hover", "Success", GetBackground(Success));
		SetStylebox("pressed", "Success", GetBackground(Success));
		SetStylebox("focus", "Success", GetBackground(Success));

		SetTypeVariation("Warning", nameof(Button));
		SetColor("font_color", "Warning", Warning);
		SetColor("icon_normal_color", "Warning", Warning);
		SetStylebox("hover", "Warning", GetBackground(Warning));
		SetStylebox("pressed", "Warning", GetBackground(Warning));
		SetStylebox("focus", "Warning", GetBackground(Warning));

		SetTypeVariation("Error", nameof(Button));
		SetColor("font_color", "Error", Error);
		SetColor("icon_normal_color", "Error", Error);
		SetStylebox("hover", "Error", GetBackground(Error));
		SetStylebox("pressed", "Error", GetBackground(Error));
		SetStylebox("focus", "Error", GetBackground(Error));
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

		SetStylebox("normal", nameof(MenuBar), GetEmpty(new Sides(Padding)));
		SetStylebox("hover", nameof(MenuBar), GetBackground(BackgroundDark, new Sides(Padding)));
		SetStylebox("pressed", nameof(MenuBar), GetBackground(BackgroundDark, new Sides(Padding)));
		SetStylebox("disabled", nameof(MenuBar), GetEmpty(new Sides(Padding)));
	}

	private void PopupMenus()
	{
		SetFont("font", nameof(PopupMenu), Font);
		SetFontSize("font_size", nameof(PopupMenu), FontSize);

		SetFont("font_separator", nameof(PopupMenu), Font);
		SetFontSize("font_separator_size", nameof(PopupMenu), FontSizeSmall);

		SetColor("font_color", nameof(PopupMenu), TextPrimary);
		SetColor("font_accelerator_color", nameof(PopupMenu), TextDisabled);
		SetColor("font_disabled_color", nameof(PopupMenu), TextDisabled);
		SetColor("font_hover_color", nameof(PopupMenu), TextActive);
		SetColor("font_separator_color", nameof(PopupMenu), TextDisabled);

		SetConstant("item_start_padding", nameof(PopupMenu), Padding);
		SetConstant("item_end_padding", nameof(PopupMenu), Padding);

		SetStylebox("panel", nameof(PopupMenu), GetBackground(Background, default, Border));
		SetStylebox("hover", nameof(PopupMenu), GetBackground(BackgroundDark, new Sides(Padding)));
		SetStylebox("separator", nameof(PopupMenu), GetLine(TextDisabled));
		SetStylebox("labeled_separator_left", nameof(PopupMenu), GetLine(TextDisabled));
		SetStylebox("labeled_separator_right", nameof(PopupMenu), GetLine(TextDisabled));
	}

	private void Windows()
	{
		SetColor("title_color", nameof(Window), TextPrimary);
		SetFont("title_font", nameof(Window), Font);
		SetFontSize("title_font_size", nameof(Window), FontSize);

		SetConstant("title_height", nameof(Window), WindowDecorations.Top);
		SetConstant("close_h_offset", nameof(Window), FontSize + 3);
		SetConstant("close_v_offset", nameof(Window), FontSize + 3);

		SetIcon("close", nameof(Window), GetIcon(Error, FontSize));
		SetIcon("close_pressed", nameof(Window), GetIcon(Error, FontSize));

		SetStylebox("embedded_border", nameof(Window), GetBackground(BackgroundDark, default, Border, WindowDecorations));
		SetStylebox("embedded_unfocused_border", nameof(Window), GetBackground(BackgroundLight, default, Border, WindowDecorations));
	}

	private void ProgressBars()
	{
		SetColor("font_color", nameof(ProgressBar), TextPrimary);
		SetFont("font", nameof(ProgressBar), Font);
		SetFontSize("font_size", nameof(ProgressBar), FontSize);

		SetStylebox("background", nameof(ProgressBar), GetBackground(BackgroundDark, new Sides(Padding, 0)));
		SetStylebox("fill", nameof(ProgressBar), GetBackground(Border));
	}
}
