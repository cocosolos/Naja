using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class AbilitiesCharge
{
    public ushort RecastId { get; set; }

    public byte Job { get; set; }

    public byte Level { get; set; }

    public byte MaxCharges { get; set; }

    public ushort ChargeTime { get; set; }

    public ushort MeritModId { get; set; }
}
