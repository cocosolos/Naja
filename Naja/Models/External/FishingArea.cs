using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class FishingArea
{
    public ushort Zoneid { get; set; }

    public ushort Areaid { get; set; }

    public string Name { get; set; } = null!;

    public byte BoundType { get; set; }

    public byte BoundHeight { get; set; }

    public ushort BoundRadius { get; set; }

    public byte[]? Bounds { get; set; }

    public float CenterX { get; set; }

    public float CenterY { get; set; }

    public float CenterZ { get; set; }
}
