using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class Zoneline
{
    public uint Zoneline1 { get; set; }

    public ushort Fromzone { get; set; }

    public ushort Tozone { get; set; }

    public float Tox { get; set; }

    public float Toy { get; set; }

    public float Toz { get; set; }

    public byte Rotation { get; set; }
}
