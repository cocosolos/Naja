using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class CharUnlock
{
    public uint Charid { get; set; }

    public uint OutpostSandy { get; set; }

    public uint OutpostBastok { get; set; }

    public uint OutpostWindy { get; set; }

    public uint MogLocker { get; set; }

    public byte RunicPortal { get; set; }

    public uint Maw { get; set; }

    public uint CampaignSandy { get; set; }

    public uint CampaignBastok { get; set; }

    public uint CampaignWindy { get; set; }

    public byte[]? Homepoints { get; set; }

    public byte[]? Survivals { get; set; }

    public uint TraverserStart { get; set; }

    public uint TraverserClaimed { get; set; }

    public byte[]? AbysseaConflux { get; set; }

    public byte[]? Waypoints { get; set; }

    public byte[]? EschanPortals { get; set; }

    public byte[]? ClaimedDeeds { get; set; }

    public byte[]? UniqueEvent { get; set; }
}
