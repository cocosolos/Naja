using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class CheatType
{
    public uint Cheatid { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public uint Argument { get; set; }

    public uint ActionBitmask { get; set; }

    public string WarningMessage { get; set; } = null!;
}
