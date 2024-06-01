using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class FishingBait
{
    public uint Baitid { get; set; }

    public string Name { get; set; } = null!;

    public byte Type { get; set; }

    public byte Maxhook { get; set; }

    public byte Losable { get; set; }

    public uint Flags { get; set; }

    public byte Mmm { get; set; }

    public byte Rankmod { get; set; }
}
