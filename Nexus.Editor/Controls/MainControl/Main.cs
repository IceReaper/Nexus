using Godot;
using LibNexus.Editor;
using Nexus.Editor.Caching;

namespace Nexus.Editor.Controls.MainControl;

public partial class Main : Control
{
	[Export]
	public required Control WindowJail { get; set; }

	[Export]
	public required PackedScene TextureViewer { get; set; }

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

	public AssetCache AssetCache { get; } = new();

	public event Action? OnProjectChanged;

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);

		if (disposing)
			AssetCache.Dispose();
	}
}
