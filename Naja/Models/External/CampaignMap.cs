using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class CampaignMap
{
    public byte Id { get; set; }

    public ushort Zoneid { get; set; }

    public byte Isbattle { get; set; }

    public byte Nation { get; set; }

    public byte Heroism { get; set; }

    public byte InfluenceSandoria { get; set; }

    public byte InfluenceBastok { get; set; }

    public byte InfluenceWindurst { get; set; }

    public byte InfluenceBeastman { get; set; }

    public ushort CurrentFortifications { get; set; }

    public ushort CurrentResources { get; set; }

    public ushort MaxFortifications { get; set; }

    public ushort MaxResources { get; set; }
}
