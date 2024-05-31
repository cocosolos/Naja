using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class MobSpawnPoint
{
    public int Mobid { get; set; }

    public string? Mobname { get; set; }

    public string? PolutilsName { get; set; }

    public uint Groupid { get; set; }

    public float PosX { get; set; }

    public float PosY { get; set; }

    public float PosZ { get; set; }

    public byte PosRot { get; set; }
}
