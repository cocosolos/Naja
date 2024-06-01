using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class CharMerit
{
    public uint Charid { get; set; }

    public ushort Meritid { get; set; }

    public ushort Upgrades { get; set; }
}
