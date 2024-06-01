using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class WeaponSkill
{
    public byte Weaponskillid { get; set; }

    public string Name { get; set; } = null!;

    public byte[] Jobs { get; set; } = null!;

    public byte Type { get; set; }

    public ushort Skilllevel { get; set; }

    public byte Element { get; set; }

    public byte Animation { get; set; }

    public ushort AnimationTime { get; set; }

    public byte Range { get; set; }

    public byte Aoe { get; set; }

    public sbyte PrimarySc { get; set; }

    public sbyte SecondarySc { get; set; }

    public sbyte TertiarySc { get; set; }

    public bool MainOnly { get; set; }

    public sbyte UnlockId { get; set; }
}
