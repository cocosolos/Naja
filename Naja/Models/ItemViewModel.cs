using Naja.Models.External;

namespace Naja.Models;

public class ItemViewModel
{
    public required ItemBasic ItemBasic { get; set; }
    public required IEnumerable<AuctionHouse> AuctionHouseHistory { get; set; }
    public required (int Singles, int Stacks) AuctionHouseStock { get; set; }
}