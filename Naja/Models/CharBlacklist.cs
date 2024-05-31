using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class CharBlacklist
{
    public uint CharidOwner { get; set; }

    public uint CharidTarget { get; set; }
}
