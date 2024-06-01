using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class CharSkill
{
    public uint Charid { get; set; }

    public byte Skillid { get; set; }

    public ushort Value { get; set; }

    public byte Rank { get; set; }
}
