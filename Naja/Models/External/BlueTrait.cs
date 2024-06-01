using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class BlueTrait
{
    public ushort TraitCategory { get; set; }

    public ushort TraitPointsNeeded { get; set; }

    public byte Traitid { get; set; }

    public ushort Modifier { get; set; }

    public short Value { get; set; }
}
