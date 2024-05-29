using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemRuneInstanceRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("definedSocketCount")]
	public uint DefinedSocketCount { get; set; }

	[Column("definedSocketType00")]
	public uint DefinedSocketType00 { get; set; }

	[Column("definedSocketType01")]
	public uint DefinedSocketType01 { get; set; }

	[Column("definedSocketType02")]
	public uint DefinedSocketType02 { get; set; }

	[Column("definedSocketType03")]
	public uint DefinedSocketType03 { get; set; }

	[Column("definedSocketType04")]
	public uint DefinedSocketType04 { get; set; }

	[Column("definedSocketType05")]
	public uint DefinedSocketType05 { get; set; }

	[Column("definedSocketType06")]
	public uint DefinedSocketType06 { get; set; }

	[Column("definedSocketType07")]
	public uint DefinedSocketType07 { get; set; }

	[Column("itemSetId")]
	public uint ItemSetId { get; set; }

	[Column("itemSetPower")]
	public uint ItemSetPower { get; set; }

	[Column("socketCountMax")]
	public uint SocketCountMax { get; set; }
}
