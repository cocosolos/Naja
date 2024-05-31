using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class StatusEffect
{
    public ushort Id { get; set; }

    public string Name { get; set; } = null!;

    public uint Flags { get; set; }

    public ushort Type { get; set; }

    public ushort? NegativeId { get; set; }

    public ushort Overwrite { get; set; }

    public ushort? BlockId { get; set; }

    public ushort RemoveId { get; set; }

    public ushort Element { get; set; }

    public ushort MinDuration { get; set; }

    public ushort SortKey { get; set; }
}
