using LibNexus.Core.Extensions;

namespace LibNexus.Files.TextureFiles;

public class TextureHeader
{
	public uint Width { get; set; }
	public uint Height { get; set; }
	public uint Depth { get; set; }
	public uint Sides { get; set; }
	public uint MipMaps { get; set; }
	public uint Format { get; set; }
	public bool IsJpg { get; set; }

	public TextureHeader(Stream stream)
	{
		Width = stream.ReadUInt32();
		Height = stream.ReadUInt32();
		Depth = stream.ReadUInt32();
		Sides = stream.ReadUInt32();
		MipMaps = stream.ReadUInt32();
		Format = stream.ReadUInt32();
		IsJpg = stream.ReadUInt32() != 0;
	}
}
