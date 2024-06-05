using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace Naja.Models.External;

public partial class ItemBasic
{
    [Key]
    public ushort Itemid { get; set; }
    public ushort Subid { get; set; }
    public string Name { get; set; } = null!;
    public string Sortname { get; set; } = null!;
    public byte StackSize { get; set; }
    public ushort Flags { get; set; }
    public byte AH { get; set; }
    public byte NoSale { get; set; }
    public uint BaseSell { get; set; }
}
