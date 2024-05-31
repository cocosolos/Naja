using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class Augment
{
    public ushort AugmentId { get; set; }

    public short Multiplier { get; set; }

    public ushort ModId { get; set; }

    public short Value { get; set; }

    public bool IsPet { get; set; }

    public byte PetType { get; set; }
}
