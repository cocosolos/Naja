using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class MobSpellList
{
    public string? SpellListName { get; set; }

    public ushort SpellListId { get; set; }

    public ushort SpellId { get; set; }

    public byte MinLevel { get; set; }

    public byte MaxLevel { get; set; }
}
