using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class GuildItemPoint
{
    public byte Guildid { get; set; }

    public ushort Itemid { get; set; }

    public ushort Rank { get; set; }

    public ushort Points { get; set; }

    public ushort MaxPoints { get; set; }

    public byte Pattern { get; set; }
}
