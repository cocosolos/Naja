using System;
using System.Collections.Generic;

namespace Naja.Models;

public partial class BcnmTreasureChest
{
    public ushort BcnmId { get; set; }

    public sbyte? BattlefieldNumber { get; set; }

    public int NpcId { get; set; }
}
