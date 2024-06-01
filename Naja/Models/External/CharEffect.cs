using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class CharEffect
{
    public uint Charid { get; set; }

    public ushort Effectid { get; set; }

    public ushort Icon { get; set; }

    public ushort Power { get; set; }

    public uint Tick { get; set; }

    public uint Duration { get; set; }

    public uint Subid { get; set; }

    public short Subpower { get; set; }

    public ushort Tier { get; set; }

    public uint Flags { get; set; }

    public uint Timestamp { get; set; }
}
