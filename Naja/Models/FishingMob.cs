using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class FishingMob
{
    public uint Mobid { get; set; }

    public string Name { get; set; } = null!;

    public ushort Zoneid { get; set; }

    public sbyte Level { get; set; }

    public ushort MinLength { get; set; }

    public ushort MaxLength { get; set; }

    public ushort Ranking { get; set; }

    public byte Difficulty { get; set; }

    public byte BaseDelay { get; set; }

    public byte BaseMove { get; set; }

    public byte Log { get; set; }

    public byte Quest { get; set; }

    public byte Nm { get; set; }

    public uint NmFlags { get; set; }

    public ushort Areaid { get; set; }

    public ushort Rarity { get; set; }

    public uint MinRespawn { get; set; }

    public uint MaxRespawn { get; set; }

    public ushort RequiredBaitid { get; set; }

    public ushort AlternativeBaitid { get; set; }

    public ushort RequiredKeyitem { get; set; }

    public byte QuestOnly { get; set; }

    public byte Disabled { get; set; }
}
