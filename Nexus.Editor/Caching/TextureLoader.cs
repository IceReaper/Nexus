using Godot;
using Texture = LibNexus.Files.TextureFiles.Texture;

namespace Nexus.Editor.Caching;

public static class TextureLoader
{
	public static Texture2D Convert(Texture texture, uint index)
	{
		return ImageTexture.CreateFromImage(
			Image.CreateFromData((int)texture.Images[index].Width, (int)texture.Images[index].Height, false, Image.Format.Rgba8, texture.Images[index].Pixels)
		);
	}
}
