using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class BlueSpellMod
{
    public ushort SpellId { get; set; }

    public ushort Modid { get; set; }

    public short Value { get; set; }
}
