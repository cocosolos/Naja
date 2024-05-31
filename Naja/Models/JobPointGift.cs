using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class JobPointGift
{
    public sbyte Jobid { get; set; }

    public short JpNeeded { get; set; }

    public short Modid { get; set; }

    public sbyte Value { get; set; }

    public string Desc { get; set; } = null!;
}
