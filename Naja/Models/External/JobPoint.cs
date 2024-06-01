using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class JobPoint
{
    public ushort JobPointid { get; set; }

    public string Name { get; set; } = null!;

    public byte Upgrade { get; set; }

    public uint Jobs { get; set; }
}
