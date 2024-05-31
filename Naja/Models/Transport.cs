using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class Transport
{
    public byte Id { get; set; }

    public string Name { get; set; } = null!;

    public uint Transport1 { get; set; }

    public uint Door { get; set; }

    public float DockX { get; set; }

    public float DockY { get; set; }

    public float DockZ { get; set; }

    public byte DockRot { get; set; }

    public ushort Boundary { get; set; }

    public byte AnimArrive { get; set; }

    public byte AnimDepart { get; set; }

    public ushort TimeOffset { get; set; }

    public ushort TimeInterval { get; set; }

    public byte TimeAnimArrive { get; set; }

    public ushort TimeWaiting { get; set; }

    public byte TimeAnimDepart { get; set; }

    public byte Zone { get; set; }
}
