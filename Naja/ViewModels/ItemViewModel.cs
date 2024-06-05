using Naja.Models.External;

namespace Naja.ViewModels;

public class ItemViewModel
{
    public required ItemBasic Basic { get; set; }
    public ItemEquipment? Equipment { get; set; }
    public ItemWeapon? Weapon { get; set; }
    public ItemUsable? ItemUsable { get; set; }
    public ItemFurnishing? ItemFurnishing { get; set; }
    public ItemPuppet? ItemPuppet { get; set; }

    public IEnumerable<AuctionHouse>? AuctionHouseHistory { get; set; }
    public (int Singles, int Stacks)? AuctionHouseStock { get; set; }

    public IEnumerable<CharInventory>? BazaarStock { get; set; }
}