using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class ItemPuppet
{
    public ushort Itemid { get; set; }

    public string Name { get; set; } = null!;

    public byte Slot { get; set; }

    public uint Element { get; set; }
}
