namespace Naja.ViewModels;

public class AuctionHouseViewModel
{
    public required uint ItemId { get; set; }
    public required string DisplayName { get; set; }
    public required byte Quantity { get; set; }
    public required byte Stack { get; set; }
    public required int Stock { get; set; }
    public required uint LatestDate { get; set; }
    public required List<Models.External.AuctionHouse> Listings { get; set; }
}