using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class ItemPuppet
{
    public ushort Itemid { get; set; }

    [ForeignKey("Itemid")]
    public virtual required ItemBasic ItemBasic { get; set; }

    public string Name { get; set; } = null!;

    public byte Slot { get; set; }

    public uint Element { get; set; }
}
