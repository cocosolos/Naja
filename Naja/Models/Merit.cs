using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class Merit
{
    public ushort Meritid { get; set; }

    public string Name { get; set; } = null!;

    public byte Upgrade { get; set; }

    public short Value { get; set; }

    public uint Jobs { get; set; }

    public byte Upgradeid { get; set; }

    public byte Catagoryid { get; set; }
}
