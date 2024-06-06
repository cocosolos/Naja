using Microsoft.EntityFrameworkCore;

using Naja.Controllers;
using Naja.Models.External;
using Naja.ViewModels;

namespace Naja.Services;

public interface IItemService
{
    Task<ItemViewModel?> GetItemViewModel(ushort id);
    bool GetSellable(ushort flags);
    List<string> GetJobs(uint jobs);
    List<string> GetFlags(ushort flags);
    List<string> GetSlots(ushort slotFlags);
    string GetSkill(byte skill);
    string? GetAhCategory(byte AH);
    string GetDmgType(uint dmgType);
}

public class ItemService : IItemService
{
    private readonly XidbContext _context;

    private static readonly Dictionary<int, string> JobMappings = new Dictionary<int, string>
    {
        {  0, "WAR" },
        {  1, "MNK" },
        {  2, "WHM" },
        {  3, "BLM" },
        {  4, "RDM" },
        {  5, "THF" },
        {  6, "PLD" },
        {  7, "DRK" },
        {  8, "BST" },
        {  9, "BRD" },
        { 10, "RNG" },
        { 11, "SAM" },
        { 12, "NIN" },
        { 13, "DRG" },
        { 14, "SMN" },
        { 15, "BLU" },
        { 16, "COR" },
        { 17, "PUP" },
        { 18, "DNC" },
        { 19, "SCH" },
        { 20, "GEO" },
        { 21, "RUN" }
    };

    private static readonly Dictionary<int, string> FlagMappings = new Dictionary<int, string>
    {
        { 0x0001, "Wall Hanging" },
        { 0x0002, "Flag 01" },
        { 0x0004, "Mystery Box" },
        { 0x0008, "Mog Garden" },
        { 0x0010, "Mail to Account" },
        { 0x0020, "Inscribable" },
        { 0x0040, "No Auction" },
        { 0x0080, "Scroll" },
        { 0x0100, "Linkshell" },
        { 0x0200, "Can Use" },
        { 0x0400, "Can Trade NPC" },
        { 0x0800, "Can Equip" },
        { 0x1000, "No Sale" },
        { 0x2000, "No Delivery" },
        { 0x4000, "EX" },
        { 0x8000, "Rare" }
    };

    private static readonly Dictionary<int, string> SlotMappings = new Dictionary<int, string>
    {
        { 0, "Main" },
        { 1, "Sub" },
        { 2, "Ranged" },
        { 3, "Ammo" },
        { 4, "Head" },
        { 5, "Body" },
        { 6, "Hands" },
        { 7, "Legs" },
        { 8, "Feet" },
        { 9, "Neck" },
        { 10, "Waist" },
        { 11, "Earring1" },
        { 12, "Earring2" },
        { 13, "Ring1" },
        { 14, "Ring2" },
        { 15, "Back" }
    };

    private static readonly Dictionary<int, string> SkillMappings = new Dictionary<int, string>
    {
        { 0, "None" },
        { 1, "Hand To Hand" },
        { 2, "Dagger" },
        { 3, "Sword" },
        { 4, "Great Sword" },
        { 5, "Axe" },
        { 6, "Great Axe" },
        { 7, "Scythe" },
        { 8, "Polearm" },
        { 9, "Katana" },
        { 10, "Great Katana" },
        { 11, "Club" },
        { 12, "Staff" },
        { 25, "Archery" },
        { 26, "Marksmanship" },
        { 27, "Throwing" },
        { 41, "String Instrument" },
        { 42, "Wind Instrument" },
        { 45, "Handbell" },
        { 48, "Fishing" }
    };

    private static readonly Dictionary<byte, string> AHMappings = new Dictionary<byte, string>
    {
        { 1, "Weapons ➞ Hand to Hand" },
        { 2, "Weapons ➞ Daggers" },
        { 3, "Weapons ➞ Swords" },
        { 4, "Weapons ➞ Great Swords" },
        { 5, "Weapons ➞ Axes" },
        { 6, "Weapons ➞ Great Axes" },
        { 7, "Weapons ➞ Scythes" },
        { 8, "Weapons ➞ Polearms" },
        { 9, "Weapons ➞ Katana" },
        { 10, "Weapons ➞ Great Katana" },
        { 11, "Weapons ➞ Clubs" },
        { 12, "Weapons ➞ Staves" },
        { 13, "Weapons ➞ Ranged" },
        { 14, "Weapons ➞ Instruments" },
        { 15, "Weapons ➞ Ammo & Misc ➞ Ammunition" },
        { 16, "Armor ➞ Shields" },
        { 17, "Armor ➞ Head" },
        { 18, "Armor ➞ Body" },
        { 19, "Armor ➞ Hands" },
        { 20, "Armor ➞ Legs" },
        { 21, "Armor ➞ Feet" },
        { 22, "Armor ➞ Neck" },
        { 23, "Armor ➞ Waist" },
        { 24, "Armor ➞ Earrings" },
        { 25, "Armor ➞ Rings" },
        { 26, "Armor ➞ Back" },
        { 28, "Scrolls ➞ White Magic" },
        { 29, "Scrolls ➞ Black Magic" },
        { 30, "Scrolls ➞ Summoning" },
        { 31, "Scrolls ➞ Ninjutsu" },
        { 32, "Scrolls ➞ Songs" },
        { 33, "Medicines" },
        { 34, "Furnishings" },
        { 35, "Crystals" },
        { 36, "Others ➞ Cards" },
        { 37, "Others ➞ Cursed Items" },
        { 38, "Materials ➞ Smithing" },
        { 39, "Materials ➞ Goldsmithing" },
        { 40, "Materials ➞ Clothcraft" },
        { 41, "Materials ➞ Leathercraft" },
        { 42, "Materials ➞ Bonecraft" },
        { 43, "Materials ➞ Woodworking" },
        { 44, "Materials ➞ Alchemy 1" },
        { 45, "Scrolls ➞ Geomancy" },
        { 46, "Others ➞ Misc. 1" },
        { 47, "Weapons ➞ Ammo & Misc. ➞ Fishing Gear" },
        { 48, "Weapons ➞ Ammo & Misc. ➞ Pet Items" },
        { 49, "Others ➞ Ninja Tools" },
        { 50, "Others ➞ Beast-Made" },
        { 51, "Food ➞ Fish" },
        { 52, "Food ➞ Meals ➞ Meat & Eggs" },
        { 53, "Food ➞ Meals ➞ Seafood" },
        { 54, "Food ➞ Meals ➞ Vegetables" },
        { 55, "Food ➞ Meals ➞ Soups" },
        { 56, "Food ➞ Meals ➞ Breads & Rice" },
        { 57, "Food ➞ Meals ➞ Sweets" },
        { 58, "Food ➞ Meals ➞ Drinks" },
        { 59, "Food ➞ Ingredients" },
        { 60, "Scrolls ➞ Dice" },
        { 61, "Others ➞ Automatons" },
        { 62, "Weapons ➞ Ammo & Misc. ➞ Grips" },
        { 63, "Materials ➞ Alchemy 2" },
        { 64, "Others ➞ Misc. 2" },
        { 65, "Others ➞ Misc. 3" }
    };

    public ItemService(XidbContext context)
    {
        _context = context;
    }

    public async Task<ItemViewModel?> GetItemViewModel(ushort id)
    {
        var item = await _context.ItemBasics
            .Where(b => b.Itemid == id)
            .Select(b => new ItemViewModel
            {
                Basic = b,
                Equipment = b.ItemEquipment,
                Weapon = b.ItemEquipment != null ? b.ItemEquipment.ItemWeapon : null,
                ItemUsable = b.ItemUsable,
                ItemFurnishing = b.ItemFurnishing,
                ItemPuppet = b.ItemPuppet,
            })
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (item == null)
        {
            return null;
        }

        item.Basic.Name = item.Basic.Name.Replace("_", " "); //.ToTitleCaseWithRomanNumerals(),
        item.Basic.Sortname = item.Basic.Sortname.Replace("_", " "); //.ToTitleCaseWithRomanNumerals(),
        item.Basic.ListFlags = GetFlags(item.Basic.Flags);
        item.Basic.Sellable = GetSellable(item.Basic.Flags);

        if (item.Equipment != null)
        {
            item.Equipment.ListJobs = GetJobs(item.Equipment.Jobs);
            item.Equipment.ListSlots = GetSlots(item.Equipment.Slot);
        }

        if (item.Weapon != null)
        {
            item.Weapon.SkillName = GetSkill(item.Weapon.Skill);
            item.Weapon.DamageType = GetDmgType(item.Weapon.DmgType);
        }

        var ahCategory = GetAhCategory(item.Basic.AH);

        if (ahCategory != null)
        {
            item.Basic.AhCategory = ahCategory;
            item.AuctionHouseHistory = await _context.AuctionHouses
                .Where(ah => ah.Itemid == id && ah.SellDate != 0)
                .OrderByDescending(ah => ah.Date)
                .AsNoTracking()
                .ToListAsync();

            var auctionHouseStock = await _context.AuctionHouses
                .Where(ah => ah.Itemid == id && ah.SellDate == 0)
                .GroupBy(ah => ah.Stack)
                .Select(g => new
                {
                    Stack = g.Key,
                    Count = g.Count()
                })
                .AsNoTracking()
                .ToListAsync();

            int singlesCount = auctionHouseStock.FirstOrDefault(g => g.Stack == 0)?.Count ?? 0;
            int stacksCount = auctionHouseStock.FirstOrDefault(g => g.Stack == 1)?.Count ?? 0;
            item.AuctionHouseStock = (singlesCount, stacksCount);
        }

        item.BazaarStock = await _context.CharInventories
            .Include(c => c.Char)
            .Where(i => i.ItemId == id && i.Bazaar > 0 && i.Char.AccountsSession != null)
            .OrderBy(i => i.Bazaar)
            .AsNoTracking()
            .ToListAsync();

        return item;
    }

    public bool GetSellable(ushort flags)
    {
        return (flags & 0x1000) == 0;
    }

    public List<string> GetJobs(uint jobs)
    {
        if (jobs == 0)
            return new List<string> { "None" };

        var appliedJobs = new List<string>();

        foreach (var job in JobMappings)
        {
            if ((jobs & (uint)Math.Pow(2, job.Key)) != 0)
            {
                appliedJobs.Add(job.Value);
            }
        }

        return appliedJobs.Count == JobMappings.Count ? new List<string> { "All Jobs" } : appliedJobs;
    }

    public List<string> GetFlags(ushort flags)
    {
        var appliedFlags = new List<string>();

        foreach (var flag in FlagMappings)
        {
            if ((flags & flag.Key) != 0)
            {
                appliedFlags.Add(flag.Value);
            }
        }

        return appliedFlags;
    }

    public List<string> GetSlots(ushort slotFlags)
    {

        if (slotFlags == 0)
            return new List<string>(["None"]);

        var validSlots = new List<string>();

        foreach (var slot in SlotMappings)
        {
            if ((slotFlags & (uint)Math.Pow(2, slot.Key)) != 0)
            {
                validSlots.Add(slot.Value);
            }
        }

        return validSlots;
    }

    public string GetSkill(byte skill)
    {
        string description = "Unknown";
        if (SkillMappings.TryGetValue(skill, out string? tempDescription))
        {
            description = tempDescription!;
        }
        return description;
    }

    public string? GetAhCategory(byte AH)
    {
        if (AHMappings.TryGetValue(AH, out string? description))
        {
            return description;
        }
        return null;
    }

    public string GetDmgType(uint dmgType)
    {
        switch (dmgType)
        {
            case 1:
                return "Piercing";
            case 2:
                return "Slashing";
            case 3:
                return "Blunt (Impact)";
            case 4:
                return "Blunt (Hand to Hand)";
            default:
                return "Unknown";
        }
    }
}