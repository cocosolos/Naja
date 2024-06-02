using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace Naja.Models.External;

public partial class ItemBasic
{
    [Key]
    public ushort Itemid { get; set; }
    public ushort Subid { get; set; }
    public string Name { get; set; } = null!;
    public string Sortname { get; set; } = null!;
    public byte StackSize { get; set; }
    public ushort Flags { get; set; }

    // Dictionary to map flag values to descriptions
    [NotMapped]
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

    // Method to get applied flag descriptions
    [NotMapped]
    public List<string> FlagsDescriptions
    {
        get
        {
            var appliedFlags = new List<string>();

            foreach (var flag in FlagMappings)
            {
                if ((Flags & flag.Key) != 0)
                {
                    appliedFlags.Add(flag.Value);
                }
            }

            return appliedFlags;
        }
    }

    public byte AH { get; set; }

    [NotMapped]
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

    [NotMapped]
    public string AHDescription
    {
        get
        {
            string description = "Unknown";
            if (AHMappings.TryGetValue(AH, out string? tempDescription))
            {
                description = tempDescription!;
            }
            return description;
        }
    }

    public byte NoSale { get; set; }

    [NotMapped]
    public bool Sellable => (Flags & 0x1000) == 0;

    public uint BaseSell { get; set; }

    public ItemUsable? ItemUsable { get; set; }
    public ItemEquipment? ItemEquipment { get; set; }
    public ItemWeapon? ItemWeapon { get; set; }
    public ItemFurnishing? ItemFurnishing { get; set; }
    public ItemPuppet? ItemPuppet { get; set; }
}
