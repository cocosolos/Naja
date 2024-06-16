using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class Char
{
    [ForeignKey("Accid")]
    public required Account Account { get; set; }

    public AccountsSession? Session { get; set; }
    public required CharStat Stats { get; set; }
    public required ICollection<CharInventory> Inventory { get; set; } = new List<CharInventory>();
}
