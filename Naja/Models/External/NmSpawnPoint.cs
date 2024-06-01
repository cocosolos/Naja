using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class NmSpawnPoint
{
    public int Mobid { get; set; }

    public byte Pos { get; set; }

    public float PosX { get; set; }

    public float PosY { get; set; }

    public float PosZ { get; set; }
}
