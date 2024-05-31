using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models;

public partial class ItemLatent
{
    public ushort ItemId { get; set; }

    [ForeignKey("ItemId")]
    public virtual required ItemBasic ItemBasic { get; set; }

    public ushort ModId { get; set; }

    public short Value { get; set; }

    public short LatentId { get; set; }

    public short LatentParam { get; set; }
}
