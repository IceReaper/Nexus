using Godot;
using LibNexus.Editor;
using ThemeBase = Nexus.Editor.Theme.ThemeBase;

namespace Nexus.Editor.Controls.MainControl;

public partial class Main : Control
{
	[Export]
	public required Control WindowJail { get; set; }

	[Export]
	public required ThemeBase ThemeBase { get; set; }

	private Project? _project;

	public Project? Project
	{
		get => _project;

		set
		{
			_project = value;
			OnProjectChanged?.Invoke();
		}
	}

	public event Action? OnProjectChanged;

	public override void _Ready()
	{
		Theme = ThemeBase.Theme;
	}
}
