﻿using LibNexus.Core;
using LibNexus.Core.Extensions;
using LibNexus.Core.Streams;
using LibNexus.Files.ArchiveFiles;
using LibNexus.Files.IndexFiles;
using SharpCompress.Compressors.LZMA;
using Index = LibNexus.Files.IndexFiles.Index;

namespace LibNexus.Files;

public class FileSystem : IDisposable
{
	private readonly DynamicFileStream _indexStream;
	private readonly Index _index;

	private readonly DynamicFileStream? _archiveStream;
	private readonly Archive? _archive;

	private readonly string? _directory;

	private FileSystem(DynamicFileStream indexStream, Index index, DynamicFileStream? archiveStream, Archive? archive, string? directory)
	{
		_indexStream = indexStream;
		_index = index;
		_archiveStream = archiveStream;
		_archive = archive;
		_directory = directory;
	}

	public static async Task<FileSystem> Create(Progress progress, string path, bool hasArchive, string? directory, CancellationToken cancellationToken)
	{
		progress.Title = "Loading FileSystem";
		progress.Total = 2;

		var indexPath = $"{path}.index";
		var archivePath = $"{path}.archive";

		var baseDirectory = Path.GetDirectoryName(path);

		if (!string.IsNullOrEmpty(baseDirectory) && !Directory.Exists(baseDirectory))
			Directory.CreateDirectory(baseDirectory);

		var indexStream = new DynamicFileStream(indexPath);
		Index index;

		if (!File.Exists(indexPath))
		{
			indexStream.Open(FileMode.Create, FileAccess.ReadWrite);
			index = await Index.Create(indexStream);
		}
		else
		{
			indexStream.Open(FileMode.Open, FileAccess.ReadWrite);

			var indexProgress = new Progress();
			progress.Children.Add(indexProgress);
			index = await Index.Read(indexStream, indexProgress, cancellationToken);
			progress.Children.Remove(indexProgress);
		}

		cancellationToken.ThrowIfCancellationRequested();

		progress.Completed++;

		DynamicFileStream? archiveStream = null;
		Archive? archive = null;

		if (hasArchive)
		{
			archiveStream = new DynamicFileStream(archivePath);

			if (!File.Exists(archivePath))
			{
				archiveStream.Open(FileMode.Create, FileAccess.ReadWrite);
				archive = await Archive.Create(archiveStream);
			}
			else
			{
				archiveStream.Open(FileMode.Open, FileAccess.ReadWrite);

				var archiveProgress = new Progress();
				progress.Children.Add(archiveProgress);
				archive = await Archive.Read(archiveStream, archiveProgress, cancellationToken);
				progress.Children.Remove(archiveProgress);
			}
		}

		progress.Completed++;

		if (directory != null && !hasArchive && !Directory.Exists(directory))
			Directory.CreateDirectory(directory);

		return new FileSystem(indexStream, index, archiveStream, archive, directory);
	}

	public void Open()
	{
		_indexStream.Open(FileMode.Open, FileAccess.ReadWrite);
		_archiveStream?.Open(FileMode.Open, FileAccess.ReadWrite);
	}

	public void Close()
	{
		_indexStream.Close();
		_archiveStream?.Close();
	}

	public void CreateDirectory(string path)
	{
		_index.CreateDirectory(path);
	}

	public string[] ListDirectories(string path)
	{
		return [.. _index.ListDirectories(path).Order()];
	}

	public string[] ListFiles(string path)
	{
		return [.. _index.ListFiles(path).Order()];
	}

	public void Rename(string oldPath, string newPath)
	{
		_index.Rename(oldPath, newPath);

		if (_directory == null)
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

		if (_directory != null)
		{
			var localPath = Path.Combine(_directory, path);

			if (File.Exists(localPath))
				return File.ReadAllBytes(localPath);
		}

		if (_archive == null)
			throw new Exception("No archive available.");

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

		if (_directory != null)
		{
			var localPath = Path.Combine(_directory, path);

			if (File.Exists(localPath))
				return file.Hash.Validate(File.ReadAllBytes(localPath));
		}

		if (_archive == null)
			throw new Exception("No archive available.");

		return _archive.Validate(file.Hash);
	}

	public void Write(string path, byte[] data, DateTime dateTime)
	{
		Delete(path);

		var file = new IndexFile
		{
			Flags = IndexFileFlags.Complete, CompressedSize = (ulong)data.Length, DecompressedSize = (ulong)data.Length, DateTime = dateTime
		};

		if (_directory != null)
		{
			file.Hash = Hash.Create(data);

			var localPath = Path.Combine(_directory, path);
			var baseDir = Path.GetDirectoryName(localPath) ?? string.Empty;

			if (!Directory.Exists(baseDir))
				Directory.CreateDirectory(baseDir);

			File.WriteAllBytes(localPath, data);
		}
		else
		{
			if (_archive == null)
				throw new Exception("No archive available.");

			using var compressedStream = new MemoryStream();
			using var lzmaStream = new LzmaStream(LzmaEncoderProperties.Default, false, compressedStream);
			lzmaStream.WriteBytes(data);
			lzmaStream.Close();
			var compressedData = compressedStream.ToArray();

			if (compressedData.Length < data.Length)
			{
				file.Flags |= IndexFileFlags.Compressed;
				file.CompressedSize = (ulong)compressedData.Length;
				file.Hash = Hash.Create(compressedData);

				_archive.Store(compressedData);
			}
			else
			{
				file.Hash = Hash.Create(data);

				_archive.Store(data);
			}
		}

		_index.WriteFile(path, file);
	}

	public void Delete(string path)
	{
		if (_index.GetFile(path) != null)
		{
			if (!_index.DeleteFile(path, out var hash))
				return;

			if (_directory != null)
			{
				var localPath = Path.Combine(_directory, path);

				if (File.Exists(localPath))
					File.Delete(localPath);
			}

			_archive?.Delete(hash);
		}
		else
		{
			foreach (var directory in _index.ListDirectories(path))
				Delete($"{path}/{directory}");

			foreach (var file in _index.ListFiles(path))
				Delete($"{path}/{file}");

			_index.DeleteDirectory(path);

			if (_directory == null)
				return;

			var localPath = Path.Combine(_directory, path);

			if (Directory.Exists(localPath) && Directory.GetFileSystemEntries(localPath).Length == 0)
				Directory.Delete(localPath);
		}
	}

	public void Unpack(string path)
	{
		if (_directory == null)
			return;

		var file = Read(path);

		if (file == null)
			return;

		var targetPath = Path.Combine(_directory, path);
		var basePath = Path.GetDirectoryName(targetPath) ?? string.Empty;

		if (!Directory.Exists(basePath))
			Directory.CreateDirectory(basePath);

		File.WriteAllBytes(targetPath, file);
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);

		_index.Dispose();
		_indexStream.Dispose();
		_archive?.Dispose();
		_archive?.Dispose();
	}
}
