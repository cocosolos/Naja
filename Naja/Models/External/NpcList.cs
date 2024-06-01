using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class NpcList
{
    public uint Npcid { get; set; }

    public byte[]? Name { get; set; }

    public string? PolutilsName { get; set; }

    public byte PosRot { get; set; }

    public float PosX { get; set; }

    public float PosY { get; set; }

    public float PosZ { get; set; }

    public uint Flag { get; set; }

    public byte Speed { get; set; }

    public byte Speedsub { get; set; }

    public byte Animation { get; set; }

    public byte Animationsub { get; set; }

    public byte Namevis { get; set; }

    public byte Status { get; set; }

    public uint EntityFlags { get; set; }

    public byte[] Look { get; set; } = null!;

    public byte NamePrefix { get; set; }

    public string? ContentTag { get; set; }

    public byte Widescan { get; set; }
}
