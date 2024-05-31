using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class ItemEquipment
{
    public ushort ItemId { get; set; }

    public string? Name { get; set; }

    public byte Level { get; set; }

    public byte Ilevel { get; set; }

    public uint Jobs { get; set; }

    public ushort Mid { get; set; }

    public byte ShieldSize { get; set; }

    public ushort ScriptType { get; set; }

    public ushort Slot { get; set; }

    public ushort Rslot { get; set; }

    public byte SuLevel { get; set; }
}
