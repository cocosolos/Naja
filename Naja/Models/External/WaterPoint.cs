using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class WaterPoint
{
    public uint Waterid { get; set; }

    public ushort Zoneid { get; set; }

    public byte Type { get; set; }

    public byte Pointid { get; set; }

    public float PosX { get; set; }

    public float PosY { get; set; }

    public float PosZ { get; set; }
}
