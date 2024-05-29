using Godot;
using LibNexus.Editor;

namespace Nexus.Editor.Controls.MainControl;

public partial class Main : Control
{
	[Export]
	public required Control WindowJail { get; set; }

	private Project? _project;

	public Project? Project
	{
		get => _project;

		set
		{
			_project?.Dispose();
			_project = value;
			OnProjectChanged?.Invoke();
		}
	}

	public event Action? OnProjectChanged;
}
