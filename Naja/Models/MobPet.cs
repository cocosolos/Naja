using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class MobPet
{
    public uint MobMobid { get; set; }

    public uint PetOffset { get; set; }

    public sbyte? Job { get; set; }

    public string? Mobname { get; set; }

    public string? Petname { get; set; }
}
