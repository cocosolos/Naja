using System;
using System.Collections.Generic;

namespace Naja.Models.External;

public partial class BcnmBattlefield
{
    public ushort BcnmId { get; set; }

    public sbyte? BattlefieldNumber { get; set; }

    public int MonsterId { get; set; }

    public sbyte Conditions { get; set; }
}
