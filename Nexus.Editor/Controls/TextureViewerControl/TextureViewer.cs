using Godot;
using Nexus.Editor.Controls.AssetViewerControl;
using Nexus.Editor.Converter;
using Nexus.Editor.Extensions;
using Texture = LibNexus.Files.TextureFiles.Texture;

namespace Nexus.Editor.Controls.TextureViewerControl;

public partial class TextureViewer : Window
{
	[Export]
	public required TextureRect TextureRect { get; set; }

	public Control? Jail { get; set; }

	public override void _Ready()
	{
		CloseRequested += QueueFree;
	}

	public override void _Process(double delta)
	{
		this.Jail(Jail);
	}

	public void Load(FileSystemPath fileSystemPath)
	{
		var data = fileSystemPath.FileSystem.Read(fileSystemPath.Path);

		if (data == null)
			return;

		using var stream = new MemoryStream(data);
		TextureRect.Texture = TextureConverter.Convert(new Texture(stream));
	}
}
