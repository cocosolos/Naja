using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class ItemPuppet
{
    [ForeignKey("Itemid")]
    public virtual required ItemBasic ItemBasic { get; set; }
}
