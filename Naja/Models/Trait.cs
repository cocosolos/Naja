using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class Trait
{
    public byte Traitid { get; set; }

    public string Name { get; set; } = null!;

    public byte Job { get; set; }

    public byte Level { get; set; }

    public byte Rank { get; set; }

    public ushort Modifier { get; set; }

    public short Value { get; set; }

    public string? ContentTag { get; set; }

    public short Meritid { get; set; }
}
