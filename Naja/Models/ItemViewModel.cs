using Naja.Models.External;

namespace Naja.Models;

public class ItemViewModel
{
    public required ItemBasic ItemBasic { get; set; }
    public required string Name { get; set; }
    public required string SortName { get; set; }
    public IEnumerable<AuctionHouse>? AuctionHouseHistory { get; set; }
    public (int Singles, int Stacks)? AuctionHouseStock { get; set; }
}