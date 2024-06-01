using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class FishingBaitAffinity
{
    public ushort Baitid { get; set; }

    public ushort Fishid { get; set; }

    public ushort Power { get; set; }
}
