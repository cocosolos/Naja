using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class AuctionHouse
{
    [ForeignKey("Itemid")]
    public required ItemBasic Item { get; set; }
}
