using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class CharEquipSaved
{
    public uint Charid { get; set; }

    public byte Jobid { get; set; }

    public ushort Main { get; set; }

    public ushort Sub { get; set; }

    public ushort Ranged { get; set; }

    public ushort Ammo { get; set; }

    public ushort Head { get; set; }

    public ushort Body { get; set; }

    public ushort Hands { get; set; }

    public ushort Legs { get; set; }

    public ushort Feet { get; set; }

    public ushort Neck { get; set; }

    public ushort Waist { get; set; }

    public ushort Ear1 { get; set; }

    public ushort Ear2 { get; set; }

    public ushort Ring1 { get; set; }

    public ushort Ring2 { get; set; }

    public ushort Back { get; set; }
}
