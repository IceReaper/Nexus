using Godot;
using Texture = LibNexus.Files.TextureFiles.Texture;

namespace Nexus.Editor.Caching;

public static class TextureLoader
{
	public static Texture2D Convert(Texture texture, uint index)
	{
		return ImageTexture.CreateFromImage(Image.CreateFromData((int)texture.Width, (int)texture.Height, false, Image.Format.Rgba8, texture.Pixels[index]));
	}
}
