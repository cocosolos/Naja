using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Naja.Models.External;

public partial class Char
{
    [ForeignKey("Accid")]
    public required Account Account { get; set; }

    [ForeignKey("Charid")]
    public AccountsSession? AccountsSession { get; set; }

    [InverseProperty("Character")]
    public ICollection<CharInventory> Inventory { get; set; } = new List<CharInventory>();
}
