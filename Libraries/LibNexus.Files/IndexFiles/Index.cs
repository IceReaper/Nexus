using LibNexus.Core;
using LibNexus.Files.PackFiles;

namespace LibNexus.Files.IndexFiles;

public class Index : IDisposable
{
	private readonly Stream _stream;
	private readonly Pack _pack;
	private readonly IndexHeader _header;

	private readonly Dictionary<uint, IndexDirectory> _directories = [];
	private readonly Dictionary<Hash, uint> _fileReferences = [];

	public Index(Stream stream, ProgressTask progressTask)
	{
		_stream = stream;
		_pack = new Pack(_stream, progressTask);

		_stream.Position = (long)_pack.Locate(_pack.RootPage);
		_header = new IndexHeader(_stream);

		progressTask.Total = _pack.VirtualPages;
		progressTask.Completed = 1;
		progressTask.UpdateDefault();

		ReadDirectory(_header.Page, progressTask);
	}

	public static Index Create(Stream stream, ProgressTask progressTask)
	{
		var pack = Pack.Create(stream, progressTask);
		pack.Update(pack.RootPage, IndexHeader.Stride);

		stream.Position = (long)pack.Locate(pack.RootPage);
		var header = IndexHeader.Create(stream);

		var rootDirectoryPage = pack.Add(IndexDirectory.Stride);
		stream.Position = (long)pack.Locate(rootDirectoryPage);
		_ = IndexDirectory.Create(stream);

		header.Page = (uint)rootDirectoryPage;

		stream.Position = 0;

		return new Index(stream, progressTask);
	}

	public void CreateDirectory(string path)
	{
		var currentPage = FindDirectory(path, out var remaining);

		_ = remaining.Aggregate(currentPage, CreateDirectory);
	}

	public string[] ListDirectories(string path)
	{
		var page = FindDirectory(path, out var remaining);

		return remaining.Length > 0 ? [] : _directories[page].Directories.Keys.ToArray();
	}

	public string[] ListFiles(string path)
	{
		var page = FindDirectory(path, out var remaining);

		return remaining.Length > 0 ? [] : _directories[page].Files.Keys.ToArray();
	}

	public void DeleteDirectory(string path)
	{
		var lastSeparator = path.LastIndexOf('/');

		var remaining = Array.Empty<string>();

		var page = lastSeparator == -1 ? _header.Page : FindDirectory(path[..lastSeparator], out remaining);
		var name = lastSeparator == -1 ? path : path[(lastSeparator + 1)..];

		if (remaining.Length > 0)
			return;

		var parentDirectory = _directories[page];

		if (!parentDirectory.Directories.TryGetValue(name, out var childPage))
			return;

		var childDirectory = _directories[childPage];

		if (childDirectory.Directories.Count > 0 || childDirectory.Files.Count > 0)
			return;

		parentDirectory.Directories.Remove(name);

		WriteDirectory(page);

		_pack.Delete(childPage);
	}

	public void Rename(string oldPath, string newPath)
	{
		var oldLastSeparator = oldPath.LastIndexOf('/');
		var newLastSeparator = newPath.LastIndexOf('/');

		var oldRemaining = Array.Empty<string>();
		var newRemaining = Array.Empty<string>();

		var oldPage = oldLastSeparator == -1 ? _header.Page : FindDirectory(oldPath[..oldLastSeparator], out oldRemaining);
		var newPage = newLastSeparator == -1 ? _header.Page : FindDirectory(newPath[..newLastSeparator], out newRemaining);

		var oldName = oldLastSeparator == -1 ? oldPath : oldPath[(oldLastSeparator + 1)..];
		var newName = newLastSeparator == -1 ? newPath : newPath[(newLastSeparator + 1)..];

		if (oldRemaining.Length > 0)
			return;

		newPage = newRemaining.Aggregate(newPage, CreateDirectory);

		var oldDirectory = _directories[oldPage];
		var newDirectory = _directories[newPage];

		if (newDirectory.Directories.ContainsKey(newName) || newDirectory.Files.ContainsKey(newName))
			return;

		if (oldDirectory.Directories.Remove(oldName, out var page))
			newDirectory.Directories.Add(newName, page);

		if (oldDirectory.Files.Remove(oldName, out var file))
			newDirectory.Files.Add(newName, file);

		WriteDirectory(oldPage);
		WriteDirectory(newPage);
	}

	public IndexFile? GetFile(string path)
	{
		var lastSeparator = path.LastIndexOf('/');

		var remaining = Array.Empty<string>();

		var page = lastSeparator == -1 ? _header.Page : FindDirectory(path[..lastSeparator], out remaining);
		var name = lastSeparator == -1 ? path : path[(lastSeparator + 1)..];

		if (remaining.Length > 0)
			return null;

		var directory = _directories[page];

		return directory.Files.GetValueOrDefault(name);
	}

	public void WriteFile(string path, IndexFile file)
	{
		var lastSeparator = path.LastIndexOf('/');

		var remaining = Array.Empty<string>();

		var page = lastSeparator == -1 ? _header.Page : FindDirectory(path[..lastSeparator], out remaining);
		var name = lastSeparator == -1 ? path : path[(lastSeparator + 1)..];

		page = remaining.Aggregate(page, CreateDirectory);

		var directory = _directories[page];

		if (directory.Directories.ContainsKey(name))
			return;

		if (!directory.Files.TryAdd(name, file))
			return;

		WriteDirectory(page);

		_fileReferences.TryAdd(file.Hash, 0);
		_fileReferences[file.Hash]++;
	}

	public bool DeleteFile(string path, out Hash hash)
	{
		var lastSeparator = path.LastIndexOf('/');

		var remaining = Array.Empty<string>();

		var page = lastSeparator == -1 ? _header.Page : FindDirectory(path[..lastSeparator], out remaining);
		var name = lastSeparator == -1 ? path : path[(lastSeparator + 1)..];

		if (remaining.Length > 0)
		{
			hash = default;

			return false;
		}

		var directory = _directories[page];
		var file = directory.Files.GetValueOrDefault(name);

		if (file == null)
		{
			hash = default;

			return false;
		}

		directory.Files.Remove(name);
		WriteDirectory(page);

		hash = file.Hash;

		_fileReferences[hash]--;

		if (_fileReferences[hash] != 0)
			return false;

		_fileReferences.Remove(hash);

		return true;
	}

	private void ReadDirectory(uint page, ProgressTask progressTask)
	{
		_stream.Position = (long)_pack.Locate(page);
		var directory = new IndexDirectory(_stream);
		_directories.Add(page, directory);

		foreach (var file in directory.Files.Values)
		{
			_fileReferences.TryAdd(file.Hash, 0);
			_fileReferences[file.Hash]++;
		}

		progressTask.Completed++;
		progressTask.UpdateDefault();

		foreach (var childPage in directory.Directories.Values)
			ReadDirectory(childPage, progressTask);
	}

	private void WriteDirectory(uint page)
	{
		var directory = _directories[page];

		_pack.Update(page, directory.Length);

		_stream.Position = (long)_pack.Locate(page);
		directory.Write(_stream);
	}

	private uint FindDirectory(string path, out string[] remaining)
	{
		var directories = path.Split('/', StringSplitOptions.RemoveEmptyEntries).ToArray();

		var page = _header.Page;

		for (var i = 0; i < directories.Length; i++)
		{
			var directory = _directories[page];
			var childName = directories[i];

			if (!directory.Directories.TryGetValue(childName, out var childPage))
			{
				remaining = directories[i..];

				return page;
			}

			page = childPage;
		}

		remaining = [];

		return page;
	}

	private uint CreateDirectory(uint parentPage, string childName)
	{
		var childPage = (uint)_pack.Add(IndexDirectory.Stride);

		_stream.Position = (long)_pack.Locate(childPage);
		var childDirectory = IndexDirectory.Create(_stream);

		_directories.Add(childPage, childDirectory);

		var parentDirectory = _directories[parentPage];
		parentDirectory.Directories.Add(childName, childPage);

		WriteDirectory(childPage);
		WriteDirectory(parentPage);

		return childPage;
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);

		_pack.Dispose();
		_stream.Dispose();
	}
}
