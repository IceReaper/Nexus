using LibNexus.Files.ArchiveFiles;
using LibNexus.Files.Extensions;
using LibNexus.Files.IndexFiles;
using SharpCompress.Compressors.LZMA;
using Index = LibNexus.Files.IndexFiles.Index;

namespace LibNexus.Files;

public class FileSystem : IDisposable
{
	private readonly Index _index;
	private readonly Archive? _archive;
	private readonly string _directory = string.Empty;

	public FileSystem(string path, string? directory = null)
	{
		var indexPath = $"{path}.index";

		var baseDirectory = Path.GetDirectoryName(path);

		if (!string.IsNullOrEmpty(baseDirectory) && !Directory.Exists(baseDirectory))
			Directory.CreateDirectory(baseDirectory);

		_index = !File.Exists(indexPath)
			? Index.Create(File.Open(indexPath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read))
			: new Index(File.Open(indexPath, FileMode.Open, FileAccess.ReadWrite, FileShare.Read));

		if (directory != null)
			_directory = directory;
		else
		{
			var archivePath = $"{path}.archive";

			_archive = !File.Exists(archivePath)
				? Archive.Create(File.Open(archivePath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read))
				: new Archive(File.Open(archivePath, FileMode.Open, FileAccess.ReadWrite, FileShare.Read));
		}
	}

	public void CreateDirectory(string path)
	{
		_index.CreateDirectory(path);
	}

	public string[] ListDirectories(string path)
	{
		return _index.ListDirectories(path);
	}

	public string[] ListFiles(string path)
	{
		return _index.ListFiles(path);
	}

	public void Rename(string oldPath, string newPath)
	{
		_index.Rename(oldPath, newPath);

		if (_archive != null)
			return;

		oldPath = Path.Combine(_directory, oldPath);
		newPath = Path.Combine(_directory, newPath);

		var baseDir = Path.GetDirectoryName(newPath) ?? string.Empty;

		if (!Directory.Exists(baseDir))
			Directory.CreateDirectory(baseDir);

		if (File.Exists(oldPath))
			File.Move(oldPath, newPath);
		else if (Directory.Exists(oldPath))
			Directory.Move(oldPath, newPath);
	}

	public byte[]? Read(string path)
	{
		var file = _index.GetFile(path);

		if (file == null)
			return null;

		if (!file.Flags.HasFlag(IndexFileFlags.Complete))
			return null;

		if (_archive == null)
		{
			path = Path.Combine(_directory, path);

			return File.Exists(path) ? File.ReadAllBytes(path) : null;
		}

		var data = _archive.Read(file.Hash);

		if (data == null)
			return null;

		if (!file.Flags.HasFlag(IndexFileFlags.Compressed))
			return data;

		var properties = new byte[5];
		Array.Copy(data, properties, properties.Length);

		using var compressedStream = new MemoryStream();
		compressedStream.Write(data, properties.Length, (int)(file.CompressedSize - (ulong)properties.Length));
		compressedStream.Position = 0;

		using var lzmaStream = new LzmaStream(properties, compressedStream);

		return lzmaStream.ReadBytes(file.DecompressedSize);
	}

	public bool Validate(string path)
	{
		var file = _index.GetFile(path);

		if (file == null)
			return false;

		if (!file.Flags.HasFlag(IndexFileFlags.Complete))
			return false;

		byte[]? data;

		if (_archive == null)
		{
			path = Path.Combine(_directory, path);

			data = File.Exists(path) ? File.ReadAllBytes(path) : null;
		}
		else
			data = _archive.Read(file.Hash);

		return data != null && file.Hash.Validate(data);
	}

	public void Write(string path, byte[] data, DateTime dateTime)
	{
		Delete(path);

		var file = new IndexFile
		{
			Flags = IndexFileFlags.Complete,
			CompressedSize = (ulong)data.Length,
			DecompressedSize = (ulong)data.Length,
			DateTime = dateTime
		};

		if (_archive == null)
		{
			path = Path.Combine(_directory, path);

			var baseDir = Path.GetDirectoryName(path) ?? string.Empty;

			if (!Directory.Exists(baseDir))
				Directory.CreateDirectory(baseDir);

			File.WriteAllBytes(path, data);
		}
		else
		{
			using var compressedStream = new MemoryStream();
			using var lzmaStream = new LzmaStream(LzmaEncoderProperties.Default, false, compressedStream);
			lzmaStream.WriteBytes(data);
			lzmaStream.Close();
			var compressedData = compressedStream.ToArray();

			if (compressedData.Length < data.Length)
			{
				file.Flags |= IndexFileFlags.Compressed;
				file.CompressedSize = (ulong)compressedData.Length;

				data = compressedData;
			}

			_archive.Store(data);
		}

		file.Hash = Hash.Create(data);

		_index.WriteFile(path, file);
	}

	public void Delete(string path)
	{
		if (_index.GetFile(path) != null)
		{
			if (!_index.DeleteFile(path, out var hash))
				return;

			if (_archive != null)
				_archive.Delete(hash);
			else
			{
				path = Path.Combine(_directory, path);

				File.Delete(path);
			}
		}
		else
		{
			foreach (var directory in _index.ListDirectories(path))
				Delete($"{path}/{directory}");

			foreach (var file in _index.ListFiles(path))
				Delete($"{path}/{file}");

			_index.DeleteDirectory(path);

			if (_archive != null)
				return;

			path = Path.Combine(_directory, path);

			if (Directory.GetFileSystemEntries(path).Length == 0)
				Directory.Delete(path);
		}
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);

		_index.Dispose();
		_archive?.Dispose();
	}
}
