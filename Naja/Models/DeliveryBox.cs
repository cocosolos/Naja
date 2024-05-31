using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class DeliveryBox
{
    public uint Charid { get; set; }

    public string? Charname { get; set; }

    public byte Box { get; set; }

    public ushort Slot { get; set; }

    public ushort Itemid { get; set; }

    public ushort Itemsubid { get; set; }

    public uint Quantity { get; set; }

    public byte[]? Extra { get; set; }

    public uint Senderid { get; set; }

    public string? Sender { get; set; }

    public bool Received { get; set; }

    public bool Sent { get; set; }
}
