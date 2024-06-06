using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class CharInventory
{
    [ForeignKey("Charid")]
    public required Char Char { get; set; }

    [ForeignKey("ItemId")]
    public required ItemBasic ItemBasic { get; set; }
}
