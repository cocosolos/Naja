using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class CharInventory
{
    public uint Charid { get; set; }

    [ForeignKey("Charid")]
    public virtual required Char Char { get; set; }

    public byte Location { get; set; }

    public byte Slot { get; set; }

    public ushort ItemId { get; set; }

    [ForeignKey("ItemId")]
    public virtual required ItemBasic ItemBasic { get; set; }

    public uint Quantity { get; set; }

    public uint Bazaar { get; set; }

    public string Signature { get; set; } = null!;

    public byte[]? Extra { get; set; }
}
