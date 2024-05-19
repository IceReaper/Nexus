using LibNexus.Files.Extensions;
using System.Collections.ObjectModel;
using System.Data;

namespace LibNexus.Files.PackFiles;

public class Pack : IDisposable
{
	private const string Magic = "PACK";
	private const uint Version = 1;

	private readonly Stream _stream;

	private readonly PackHeader _header;
	private readonly Collection<PackPhysicalPage> _physicalPages = [];
	private readonly Collection<PackVirtualPage> _virtualPages = [];

	private PackPhysicalPage VirtualPagesPhysicalPage => _physicalPages.First(physicalPage => physicalPage.Offset == _header.VirtualPagesOffset);

	public ulong RootPage => _header.RootPage;

	public Pack(Stream stream)
	{
		_stream = stream;

		if (_stream.Position != 0)
			throw new ConstraintException("Pack: Invalid stream position");

		var pack = stream.ReadWord();
		var version = stream.ReadUInt32();

		if (pack != Magic)
			throw new DataException("Pack: Invalid magic");

		if (version != Version)
			throw new DataException("Pack: Invalid version");

		_header = new PackHeader(_stream);

		while (_stream.Position < (long)_header.Length)
		{
			var physicalPage = new PackPhysicalPage(_stream) { Last = _physicalPages.LastOrDefault() };

			if (physicalPage.Last != null)
				physicalPage.Last.Next = physicalPage;

			_physicalPages.Add(physicalPage);
		}

		_stream.Position = (long)VirtualPagesPhysicalPage.Offset;

		for (var i = 0UL; i < _header.VirtualPages; i++)
		{
			var virtualPage = new PackVirtualPage(_stream, _header, i);
			var physicalPage = _physicalPages.FirstOrDefault(physicalPage => physicalPage.Offset == virtualPage.Offset);

			if (physicalPage != null)
			{
				physicalPage.VirtualPages.Add(virtualPage);
				virtualPage.PhysicalPage = physicalPage;
			}

			_virtualPages.Add(virtualPage);
		}
	}

	public static Pack Create(Stream stream)
	{
		if (stream.Position != 0)
			throw new ConstraintException("Pack: Invalid stream position");

		if (stream.Length != 0)
			throw new ConstraintException("Pack: Stream not empty");

		stream.WriteWord(Magic);
		stream.WriteUInt32(Version);

		var header = PackHeader.Create(stream);

		var virtualPagesPhysicalPage = PackPhysicalPage.Create(stream, PackVirtualPage.Stride * 2);
		header.Length += PackPhysicalPage.Stride + PackVirtualPage.Stride * 2;

		header.VirtualPagesOffset = virtualPagesPhysicalPage.Offset;
		header.VirtualPages = 2;

		stream.Position = (long)header.VirtualPagesOffset;
		PackVirtualPage.Create(stream, header, 0);
		var rootVirtualPage = PackVirtualPage.Create(stream, header, 1);
		stream.Position += PackVirtualPage.Stride / 2;

		var rootPhysicalPage = PackPhysicalPage.Create(stream, 0);
		header.Length += PackPhysicalPage.Stride;

		rootVirtualPage.Offset = rootPhysicalPage.Offset;

		header.RootPage = rootVirtualPage.Index;

		stream.Position = 0;

		return new Pack(stream);
	}

	public ulong Add(ulong length)
	{
		var virtualPage = AllocateVirtualPage();
		var physicalPage = AllocatePhysicalPage(length);

		virtualPage.Offset = physicalPage.Offset;
		virtualPage.Length = length;
		virtualPage.PhysicalPage = physicalPage;

		physicalPage.VirtualPages.Add(virtualPage);

		return virtualPage.Index;
	}

	public ulong Locate(ulong page)
	{
		if (page >= _header.VirtualPages)
			return 0;

		var virtualPage = _virtualPages[(int)page];

		return virtualPage.Offset;
	}

	public void Update(ulong page, ulong length)
	{
		if (page >= _header.VirtualPages)
			return;

		var virtualPage = _virtualPages[(int)page];
		var physicalPage = virtualPage.PhysicalPage;

		if (physicalPage == null)
		{
			physicalPage = AllocatePhysicalPage(length);

			virtualPage.Offset = physicalPage.Offset;
			virtualPage.Length = length;
			virtualPage.PhysicalPage = physicalPage;

			physicalPage.VirtualPages.Add(virtualPage);
		}
		else
		{
			ResizePhysicalPage(physicalPage, length);

			virtualPage.Length = length;
		}
	}

	public void Delete(ulong page)
	{
		if (page >= _header.VirtualPages)
			return;

		var virtualPage = _virtualPages[(int)page];
		var physicalPage = virtualPage.PhysicalPage;

		if (physicalPage == null)
			return;

		virtualPage.Offset = 0;
		virtualPage.Length = 0;
		virtualPage.PhysicalPage = null;

		physicalPage.VirtualPages.Remove(virtualPage);

		if (physicalPage.VirtualPages.Count == 0)
			DeletePhysicalPage(physicalPage);
	}

	private PackVirtualPage AllocateVirtualPage()
	{
		for (var i = 1; i < (int)_header.VirtualPages; i++)
		{
			var virtualPage = _virtualPages[i];

			if (virtualPage.PhysicalPage == null)
				return virtualPage;
		}

		var length = (_header.VirtualPages + 1) * PackVirtualPage.Stride;

		if (VirtualPagesPhysicalPage.Length < length)
		{
			var newVirtualPagesPhysicalPage = ResizePhysicalPage(VirtualPagesPhysicalPage, length);
			_header.VirtualPagesOffset = newVirtualPagesPhysicalPage.Offset;
		}

		_stream.Position = (long)VirtualPagesPhysicalPage.Offset + (long)(_header.VirtualPages * PackVirtualPage.Stride);
		var newVirtualPage = new PackVirtualPage(_stream, _header, _header.VirtualPages);
		_virtualPages.Add(newVirtualPage);

		_header.VirtualPages++;

		return newVirtualPage;
	}

	private PackPhysicalPage AllocatePhysicalPage(ulong length)
	{
		foreach (var physicalPage in _physicalPages)
		{
			if (physicalPage == VirtualPagesPhysicalPage || physicalPage.VirtualPages.Count != 0)
				continue;

			if (physicalPage.Length >= length || physicalPage.Next == null)
				return ResizePhysicalPage(physicalPage, length);
		}

		_stream.Position = (long)_header.Length;

		var newPhysicalPage = PackPhysicalPage.Create(_stream, length);

		newPhysicalPage.Last = _physicalPages.LastOrDefault();

		if (newPhysicalPage.Last != null)
			newPhysicalPage.Last.Next = newPhysicalPage;

		_physicalPages.Add(newPhysicalPage);

		_header.Length += length + PackPhysicalPage.Stride;

		return newPhysicalPage;
	}

	private PackPhysicalPage ResizePhysicalPage(PackPhysicalPage physicalPage, ulong length)
	{
		MergeLast(physicalPage);
		MergeNext(physicalPage);

		if (physicalPage.Length > length + PackPhysicalPage.Stride)
		{
			var remaining = physicalPage.Length - length - PackPhysicalPage.Stride;

			physicalPage.Length -= remaining + PackPhysicalPage.Stride;

			_stream.Position = (long)(physicalPage.Offset + physicalPage.Length + PackPhysicalPage.Stride / 2);

			var remainingPhysicalPage = PackPhysicalPage.Create(_stream, remaining);
			remainingPhysicalPage.Last = physicalPage;
			remainingPhysicalPage.Next = physicalPage.Next;

			if (physicalPage.Next != null)
				physicalPage.Next.Last = remainingPhysicalPage;

			physicalPage.Next = remainingPhysicalPage;

			_physicalPages.Insert(_physicalPages.IndexOf(physicalPage) + 1, remainingPhysicalPage);

			return physicalPage;
		}

		if (physicalPage.Length >= length)
			return physicalPage;

		if (physicalPage.Next == null)
		{
			var missing = length - physicalPage.Length;

			_header.Length += missing;
			physicalPage.Length += missing;

			return physicalPage;
		}

		_stream.Position = (long)physicalPage.Offset;
		var data = _stream.ReadBytes(physicalPage.Length);

		_stream.Position = (long)physicalPage.Offset;
		_stream.WriteBytes(new byte[physicalPage.Length]);

		var newPhysicalPage = AllocatePhysicalPage(length);

		_stream.Position = (long)newPhysicalPage.Offset;
		_stream.WriteBytes(data);

		foreach (var virtualPage in physicalPage.VirtualPages)
		{
			virtualPage.Offset = newPhysicalPage.Offset;
			virtualPage.PhysicalPage = newPhysicalPage;
			newPhysicalPage.VirtualPages.Add(virtualPage);
		}

		physicalPage.VirtualPages.Clear();

		return newPhysicalPage;
	}

	private void DeletePhysicalPage(PackPhysicalPage physicalPage)
	{
		_stream.Position = (long)physicalPage.Offset;
		_stream.WriteBytes(new byte[physicalPage.Length]);

		MergeLast(physicalPage);
		MergeNext(physicalPage);

		if (physicalPage.Next != null)
			return;

		_physicalPages.Remove(physicalPage);
		_header.Length = physicalPage.Offset - PackPhysicalPage.Stride / 2;
	}

	private void MergeLast(PackPhysicalPage physicalPage)
	{
		if (physicalPage.Last is not { VirtualPages.Count: 0 } || physicalPage.Last == VirtualPagesPhysicalPage)
			return;

		var remove = physicalPage.Last;
		var grow = remove.Length;

		remove.Length = 0;
		_physicalPages.Remove(remove);

		physicalPage.Last = remove.Last;

		if (remove.Last != null)
			remove.Last.Next = physicalPage;

		physicalPage.Offset -= grow + PackPhysicalPage.Stride;
		physicalPage.Length += grow + PackPhysicalPage.Stride;
	}

	private void MergeNext(PackPhysicalPage physicalPage)
	{
		if (physicalPage.Next is not { VirtualPages.Count: 0 } || physicalPage.Next == VirtualPagesPhysicalPage)
			return;

		var remove = physicalPage.Next;
		var grow = remove.Length;

		remove.Length = 0;
		_physicalPages.Remove(remove);

		physicalPage.Next = remove.Next;

		if (physicalPage.Next != null)
			physicalPage.Next.Last = physicalPage;

		physicalPage.Length += grow + PackPhysicalPage.Stride;
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);

		_stream.Dispose();
	}
}
