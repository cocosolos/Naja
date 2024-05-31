using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class PetList
{
    public uint Petid { get; set; }

    public string Name { get; set; } = null!;

    public uint Poolid { get; set; }

    public byte MinLevel { get; set; }

    public byte MaxLevel { get; set; }

    public uint Time { get; set; }

    public byte Element { get; set; }

    public byte DamageType { get; set; }
}
