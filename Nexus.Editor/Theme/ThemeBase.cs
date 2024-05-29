using Godot;

namespace Nexus.Editor.Theme;

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

		if (disposing)
			_appTheme.Dispose();
	}
}
