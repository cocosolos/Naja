using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class GardeningResult
{
    public ushort ResultId { get; set; }

    public byte Seed { get; set; }

    public byte Element1 { get; set; }

    public byte Element2 { get; set; }

    public ushort Result { get; set; }

    public byte MinQuantity { get; set; }

    public byte MaxQuantity { get; set; }

    public ushort Weight { get; set; }
}
