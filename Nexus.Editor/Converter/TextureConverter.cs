using Godot;
using Texture = LibNexus.Files.TextureFiles.Texture;

namespace Nexus.Editor.Converter;

public static class TextureConverter
{
	public static Texture2D Convert(Texture texture, uint maxSize = uint.MaxValue)
	{
		var image = texture.Images.FirstOrDefault(mipImage => mipImage.Width >= maxSize || mipImage.Height >= maxSize) ?? texture.Images.Last();

		return ImageTexture.CreateFromImage(Image.CreateFromData((int)image.Width, (int)image.Height, false, Image.Format.Rgba8, image.Pixels));
	}
}
