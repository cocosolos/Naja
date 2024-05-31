namespace Naja.Models;

public class AuctionHouseViewModel
{
    public required uint ItemId { get; set; }
    public required byte Stack { get; set; }
    public required int Stock { get; set; }
    public required uint LatestDate { get; set; }
    public required List<AuctionHouse> Listings { get; set; }
}