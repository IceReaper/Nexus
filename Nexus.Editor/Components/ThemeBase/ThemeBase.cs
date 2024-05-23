using Godot;

namespace Nexus.Editor.Components.ThemeBase;

[Tool]
public partial class ThemeBase : PanelContainer
{
	private readonly AppTheme _appTheme = new();

	public ThemeBase()
	{
		Theme = _appTheme;
	}

	public override void _Notification(int what)
	{
		if (what == NotificationEditorPreSave)
			Theme = null;
		else if (what == NotificationEditorPostSave)
			Theme = _appTheme;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);

		_appTheme.Dispose();
	}
}
