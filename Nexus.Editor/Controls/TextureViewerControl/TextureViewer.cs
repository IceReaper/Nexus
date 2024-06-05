using Godot;
using Nexus.Editor.Caching;
using Nexus.Editor.Controls.AssetViewerControl;
using Nexus.Editor.Controls.MainControl;
using Nexus.Editor.Extensions;
using Texture = LibNexus.Files.TextureFiles.Texture;

namespace Nexus.Editor.Controls.TextureViewerControl;

public partial class TextureViewer : Window
{
	[Export]
	public required TextureRect TextureRect { get; set; }

	[Export]
	public required Button Previous { get; set; }

	[Export]
	public required Label Current { get; set; }

	[Export]
	public required Button Next { get; set; }

	public Main? Main { get; set; }
	public FileSystemPath? FileSystemPath { get; set; }

	private int _current;
	private Texture? _texture;

	public override void _Ready()
	{
		CloseRequested += QueueFree;

		Previous.Pressed += () => SelectTexture(_current - 1);
		Next.Pressed += () => SelectTexture(_current + 1);

		if (FileSystemPath == null)
			return;

		Main?.AssetCache.Add(
			this,
			FileSystemPath.Path,
			() =>
			{
				var data = FileSystemPath.FileSystem.Read(FileSystemPath.Path);

				if (data == null)
					return null;

				using var stream = new MemoryStream(data);

				return new Texture(stream);
			},
			texture =>
			{
				_texture = texture;
				CallDeferred(nameof(SelectTexture), 0);
			},
			true
		);
	}

	public override void _Process(double delta)
	{
		if (Main != null)
			this.Jail(Main.WindowJail);
	}

	private void SelectTexture(int index)
	{
		if (_texture == null || FileSystemPath == null)
			return;

		if (TextureRect.Texture != null)
			Main?.AssetCache.Remove(this, $"{FileSystemPath.Path}:{_current}");

		_current = index;

		Current.Text = $"{_current + 1} / {_texture.Images.Length}";
		Previous.Disabled = _current == 0;
		Next.Disabled = _current == _texture.Images.Length - 1;

		Main?.AssetCache.Add(
			this,
			$"{FileSystemPath.Path}:{_current}",
			() => TextureLoader.Convert(_texture, (uint)_current),
			texture => CallDeferred(nameof(SetTexture), texture),
			true
		);
	}

	private void SetTexture(Texture2D texture)
	{
		TextureRect.Texture = texture;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);

		if (disposing)
			Main?.AssetCache.Remove(this);
	}
}
