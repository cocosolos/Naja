using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class CharPet
{
    public uint Charid { get; set; }

    public ushort Wyvernid { get; set; }

    public ushort Automatonid { get; set; }

    public byte[]? UnlockedAttachments { get; set; }

    public byte[]? EquippedAttachments { get; set; }

    public ushort Adventuringfellowid { get; set; }

    public uint Chocoboid { get; set; }

    public uint FieldChocobo { get; set; }
}
