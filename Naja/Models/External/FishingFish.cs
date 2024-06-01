using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class FishingFish
{
    public uint Fishid { get; set; }

    public string Name { get; set; } = null!;

    public byte SkillLevel { get; set; }

    public byte Difficulty { get; set; }

    public byte BaseDelay { get; set; }

    public byte BaseMove { get; set; }

    public ushort MinLength { get; set; }

    public ushort MaxLength { get; set; }

    public ushort Ranking { get; set; }

    public byte SizeType { get; set; }

    public byte WaterType { get; set; }

    public byte Log { get; set; }

    public byte Quest { get; set; }

    public byte QuestStatus { get; set; }

    public uint Flags { get; set; }

    public byte HourPattern { get; set; }

    public byte MoonPattern { get; set; }

    public byte MonthPattern { get; set; }

    public uint Legendary { get; set; }

    public uint LegendaryFlags { get; set; }

    public byte Item { get; set; }

    public byte MaxHook { get; set; }

    public ushort Rarity { get; set; }

    public ushort RequiredKeyitem { get; set; }

    public byte[] RequiredCatches { get; set; } = null!;

    public uint Family { get; set; }

    public byte QuestOnly { get; set; }

    public sbyte Contest { get; set; }

    public byte Disabled { get; set; }
}
