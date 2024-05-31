using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class MobGroup
{
    public uint Groupid { get; set; }

    public uint Poolid { get; set; }

    public ushort Zoneid { get; set; }

    public string? Name { get; set; }

    public uint Respawntime { get; set; }

    public byte Spawntype { get; set; }

    public uint Dropid { get; set; }

    public int Hp { get; set; }

    public int Mp { get; set; }

    public byte MinLevel { get; set; }

    public byte MaxLevel { get; set; }

    public byte Allegiance { get; set; }
}
