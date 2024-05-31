using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class MobPoolMod
{
    public ushort Poolid { get; set; }

    public ushort Modid { get; set; }

    public short Value { get; set; }

    public bool IsMobMod { get; set; }
}
