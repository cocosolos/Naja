using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class CharBlacklist
{
    public uint CharidOwner { get; set; }

    public uint CharidTarget { get; set; }
}
