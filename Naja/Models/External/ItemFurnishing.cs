using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class ItemFurnishing
{
    public ushort Itemid { get; set; }

    [ForeignKey("Itemid")]
    public virtual required ItemBasic ItemBasic { get; set; }

    public string Name { get; set; } = null!;

    public byte Storage { get; set; }

    public ushort Moghancement { get; set; }

    public byte Element { get; set; }

    public byte Aura { get; set; }
}
