using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class FishingGroup
{
    public uint Groupid { get; set; }

    public uint Fishid { get; set; }

    public ushort Rarity { get; set; }

    public ushort PoolSize { get; set; }

    public ushort RestockRate { get; set; }
}
