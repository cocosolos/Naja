using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class MobSpawnMod
{
    public uint Mobid { get; set; }

    public ushort Modid { get; set; }

    public short Value { get; set; }

    public bool IsMobMod { get; set; }
}
