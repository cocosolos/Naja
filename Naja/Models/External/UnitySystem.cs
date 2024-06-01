using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class UnitySystem
{
    public sbyte Leader { get; set; }

    public int MembersCurrent { get; set; }

    public double PointsCurrent { get; set; }

    public int MembersPrev { get; set; }

    public double PointsPrev { get; set; }
}
