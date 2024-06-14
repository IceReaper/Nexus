using LibNexus.Core.Extensions;

namespace LibNexus.Files.ModelFiles;

public class ModelMaterialData
{
	public ModelMaterialData(Stream stream)
	{
		var texture1 = stream.ReadUInt16();
		var texture2 = stream.ReadUInt16();
		stream.ReadBytes(68); // TODO
		var unk1 = stream.ReadUInt32();
		stream.ReadBytes(20); // TODO
		var unk2 = stream.ReadUInt32();
		stream.ReadBytes(204); // TODO

		if (unk1 == 1)
			stream.ReadBytes(32); // TODO

		if (unk2 == 1)
			stream.ReadBytes(32); // TODO
	}
}
