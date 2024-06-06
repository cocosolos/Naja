using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class ItemLatent
{
    public ushort ItemId { get; set; }

    public ushort ModId { get; set; }

    public short Value { get; set; }

    public short LatentId { get; set; }

    public short LatentParam { get; set; }
}
