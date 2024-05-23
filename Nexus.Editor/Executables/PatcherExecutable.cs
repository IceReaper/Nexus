using System.Data;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Nexus.Editor.Executables;

public class PatcherExecutable
{
	private static readonly byte[] Hash =
	[
		0x28, 0x34, 0xF3, 0xD0, 0x87, 0xE6, 0x21, 0x45, 0x4F, 0x24, 0xED, 0x14, 0x3A, 0xDF, 0x12, 0x4F, 0xEB, 0x55, 0x2B, 0x83
	];

	private readonly string _path;

	private byte[] Bytes { get; }

	public PatcherExecutable(string path)
	{
		_path = path;
		Bytes = File.ReadAllBytes(path);

		if (!SHA1.HashData(Bytes).SequenceEqual(Hash))
			throw new DataException("Invalid executable file");
	}

	public void SetServerHost(string host)
	{
		var urlBytes = new byte[56];

		if (host.Length >= urlBytes.Length / 2)
			throw new DataException("Url is too long");

		for (var i = 0; i < host.Length; i++)
			urlBytes[i * 2] = (byte)host[i];

		Array.Copy(urlBytes, 0, Bytes, 0x16CCF4, urlBytes.Length);
		Array.Copy(urlBytes, 0, Bytes, 0x16CD76, urlBytes.Length);
	}
}
