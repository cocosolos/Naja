using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class MobFamilySystem
{
    public ushort FamilyId { get; set; }

    public string? Family { get; set; }

    public ushort SuperFamilyId { get; set; }

    public string? SuperFamily { get; set; }

    public byte EcosystemId { get; set; }

    public string? Ecosystem { get; set; }

    public float Mobradius { get; set; }

    public byte Speed { get; set; }

    public byte Hp { get; set; }

    public byte Mp { get; set; }

    public ushort Str { get; set; }

    public ushort Dex { get; set; }

    public ushort Vit { get; set; }

    public ushort Agi { get; set; }

    public ushort Int { get; set; }

    public ushort Mnd { get; set; }

    public ushort Chr { get; set; }

    public ushort Att { get; set; }

    public ushort Def { get; set; }

    public ushort Acc { get; set; }

    public ushort Eva { get; set; }

    public float Element { get; set; }

    public short Detects { get; set; }

    public sbyte Charmable { get; set; }
}
