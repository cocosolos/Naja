using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class ConquestSystem
{
    public sbyte RegionId { get; set; }

    public sbyte RegionControl { get; set; }

    public sbyte RegionControlPrev { get; set; }

    public int SandoriaInfluence { get; set; }

    public int BastokInfluence { get; set; }

    public int WindurstInfluence { get; set; }

    public int BeastmenInfluence { get; set; }
}
