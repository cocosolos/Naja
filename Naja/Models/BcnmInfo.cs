using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class BcnmInfo
{
    public ushort BcnmId { get; set; }

    public byte ZoneId { get; set; }

    public string Name { get; set; } = null!;

    public string? FastestName { get; set; }

    public byte FastestPartySize { get; set; }

    public uint? FastestTime { get; set; }

    public ushort TimeLimit { get; set; }

    public ushort LevelCap { get; set; }

    public ushort PartySize { get; set; }

    public ushort LootDropId { get; set; }

    public ushort Rules { get; set; }

    public byte IsMission { get; set; }
}
