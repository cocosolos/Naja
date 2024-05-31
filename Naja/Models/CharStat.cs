using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class CharStat
{
    public uint Charid { get; set; }

    public ushort Hp { get; set; }

    public ushort Mp { get; set; }

    public ushort Mhflag { get; set; }

    public byte Mjob { get; set; }

    public byte Sjob { get; set; }

    public uint Death { get; set; }

    public uint _2h { get; set; }

    public ushort Title { get; set; }

    public byte[]? BazaarMessage { get; set; }

    public byte Zoning { get; set; }

    public byte Mlvl { get; set; }

    public byte Slvl { get; set; }

    public ushort PetId { get; set; }

    public ushort PetType { get; set; }

    public ushort PetLevel { get; set; }

    public ushort PetHp { get; set; }

    public ushort PetMp { get; set; }
}
