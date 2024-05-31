namespace Naja.Models;

public class ItemViewModel
{
    public required ItemBasic ItemBasic { get; set; }
    public required IEnumerable<AuctionHouse> AuctionHouse { get; set; }
    public required IEnumerable<IGrouping<byte, AuctionHouse>> AuctionHouseStock { get; set; }
}