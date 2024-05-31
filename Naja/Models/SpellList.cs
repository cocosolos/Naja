using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class SpellList
{
    public ushort Spellid { get; set; }

    public string Name { get; set; } = null!;

    public byte[] Jobs { get; set; } = null!;

    public byte Group { get; set; }

    public ushort Family { get; set; }

    public byte Element { get; set; }

    public ushort Zonemisc { get; set; }

    public ushort ValidTargets { get; set; }

    public byte Skill { get; set; }

    public ushort MpCost { get; set; }

    public ushort CastTime { get; set; }

    public uint RecastTime { get; set; }

    public ushort Message { get; set; }

    public short MagicBurstMessage { get; set; }

    public ushort Animation { get; set; }

    public ushort AnimationTime { get; set; }

    public byte Aoe { get; set; }

    public ushort Base { get; set; }

    public float Multiplier { get; set; }

    public uint Ce { get; set; }

    public uint Ve { get; set; }

    public sbyte Requirements { get; set; }

    public ushort SpellRange { get; set; }

    public string? ContentTag { get; set; }
}
