using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class CharInventory
{
    public uint Charid { get; set; }

    public byte Location { get; set; }

    public byte Slot { get; set; }

    public ushort ItemId { get; set; }

    public uint Quantity { get; set; }

    public uint Bazaar { get; set; }

    public string Signature { get; set; } = null!;

    public byte[]? Extra { get; set; }
}
