using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class ItemLatent
{
    [ForeignKey("ItemId")]
    public virtual required ItemBasic ItemBasic { get; set; }
}
