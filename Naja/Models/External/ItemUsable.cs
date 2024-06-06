using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class ItemUsable
{
    public ushort Itemid { get; set; }

    public string Name { get; set; } = null!;

    public ushort ValidTargets { get; set; }

    public byte Activation { get; set; }

    public ushort Animation { get; set; }

    public byte AnimationTime { get; set; }

    public byte MaxCharges { get; set; }

    public byte UseDelay { get; set; }

    public uint ReuseDelay { get; set; }

    public byte Aoe { get; set; }
}
