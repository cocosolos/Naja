using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class FishingCatch
{
    public ushort Zoneid { get; set; }

    public byte Areaid { get; set; }

    public ushort Groupid { get; set; }
}
