using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class CharJobPoint
{
    public uint Charid { get; set; }

    public byte Jobid { get; set; }

    public ushort CapacityPoints { get; set; }

    public ushort JobPoints { get; set; }

    public ushort JobPointsSpent { get; set; }

    public byte Jptype0 { get; set; }

    public byte Jptype1 { get; set; }

    public byte Jptype2 { get; set; }

    public byte Jptype3 { get; set; }

    public byte Jptype4 { get; set; }

    public byte Jptype5 { get; set; }

    public byte Jptype6 { get; set; }

    public byte Jptype7 { get; set; }

    public byte Jptype8 { get; set; }

    public byte Jptype9 { get; set; }
}
