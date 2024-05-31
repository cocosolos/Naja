using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class FishingZone
{
    public ushort Zoneid { get; set; }

    public string Name { get; set; } = null!;

    public byte Difficulty { get; set; }
}
