using Naja.Models.External;

namespace Naja.ViewModels;

public class ItemViewModel
{
    public required string DisplayName { get; set; }
    public string? Description { get; set; }
    public required ItemBasic Basic { get; set; }
    public ItemEquipment? Equipment { get; set; }
    public ItemWeapon? Weapon { get; set; }
    public ItemUsable? ItemUsable { get; set; }
    public ItemFurnishing? ItemFurnishing { get; set; }
    public ItemPuppet? ItemPuppet { get; set; }
    public CharInventory? Inventory { get; set; }

    public IEnumerable<AuctionHouse>? AuctionHouseHistory { get; set; }
    public (int Singles, int Stacks)? AuctionHouseStock { get; set; }

    public IEnumerable<CharInventory>? BazaarStock { get; set; }
}