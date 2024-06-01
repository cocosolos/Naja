using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class ItemModsPet
{
    public ushort ItemId { get; set; }

    [ForeignKey("ItemId")]
    public virtual required ItemBasic ItemBasic { get; set; }

    public ushort ModId { get; set; }

    public short Value { get; set; }

    public byte PetType { get; set; }
}
