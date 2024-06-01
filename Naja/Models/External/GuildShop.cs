using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class GuildShop
{
    public ushort Guildid { get; set; }

    public ushort Itemid { get; set; }

    public uint MinPrice { get; set; }

    public uint MaxPrice { get; set; }

    public ushort MaxQuantity { get; set; }

    public ushort DailyIncrease { get; set; }

    public ushort InitialQuantity { get; set; }
}
