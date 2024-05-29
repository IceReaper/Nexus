using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TicketSubCategoryRow
{
	[Column("ID")]
	public uint Id { get; set; }

	[Column("ticketCategoryId")]
	public uint TicketCategoryId { get; set; }

	[Column("localizedTextId")]
	public uint LocalizedTextId { get; set; }
}
